using SoulsFormats;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ERregulator
{
    class ERregulator
    {
        private readonly Random rand;

        public ERregulator(string seed)
        {
            if (seed == string.Empty)
                rand = new Random();
            else
                rand = new Random(seed.GetHashCode());
        }

        public void Randomize(
            Dictionary<string, 
            PARAM> paramDict,
            bool doArmor, bool randomizeArmorWeight,
            bool doWeapons, bool randomizeWeaponsWeight, bool keepWeaponCategories,
            bool doRings, bool randomizeRingsWeight,
            bool doGoods, 
            bool doSpells, int spellEffectSlots,
            bool doBullets, bool bulletsPlus, 
            bool doHumans, 
            bool doOthers
        )
        {
            if (doBullets)
            {
                PARAM param = paramDict["Bullet"];
                RandomizeAll(param.Rows, bulletsPlus);
            }

            if (doRings)
            {
                PARAM param = paramDict["EquipParamAccessory"];
                var rings = param.Rows.Where(row => (byte)row["accessoryCategory"].Value == 0 && row.ID < 900000);
                RandomizeSome(rings, "refId0");

                if (randomizeRingsWeight)
                    RandomizeSome(rings, "weight");
            }

            if (doGoods)
            {
                PARAM param = paramDict["EquipParamGoods"];

                // Skip flasks of wondrous physicks and spectral steed whistle,
                // therefore extract a list that does not include the flask
                // consumables
                int flaskStart = 1000;
                int flaskEnd = 1075;
                int spectralSteedWhistle = 130;
                var usable = param.Rows.Where(
                    row => 
                      !(row.ID >= flaskStart
                    &&  row.ID <= flaskEnd)
                    &&  row.ID != spectralSteedWhistle
                );

                RandomizeSome(usable, "sfxVariationId", "goodsUseAnim");
                RandomizePair<byte, int>(usable, "refCategory", "refId_1");
            }

            if (doArmor)
            {
                PARAM param = paramDict["EquipParamProtector"];
                var valid = param.Rows.Where(row => row.ID >= 1000000);
                RandomizeSome(valid,
                    "residentSpEffectId", 
                    "residentSpEffectId2", 
                    "residentSpEffectId3", 

                    "resistPoison", 
                    "resistDisease",
                    "resistBlood",
                    "resistMadness", 
                    "resistSleep", 
                    "resistCurse", 
                    "resistFrost",

                    "knockBack", // Is this poise?
                    "knockbackBounceRate",

                    "defensePhysics",
                    "defenseMagic",
                    "defenseFire",
                    "defenseThunder",
                    "defenseSlash",
                    "defenseBlow",
                    "defenseThrust",
                    "defenseDark",

                    "neutralDamageCutRate",
                    "slashDamageCutRate",
                    "blowDamageCutRate",
                    "thrustDamageCutRate",
                    "magicDamageCutRate",
                    "fireDamageCutRate",
                    "thunderDamageCutRate",
                    "toughnessDamageCutRate",
                    "darkDamageCutRate",

                    "defenseMaterialSfx1",
                    "defenseMaterialSfx2"
                );

                if (randomizeArmorWeight)
                    RandomizeSome(valid, "weight");
            }

            if (doWeapons)
            {
                // Always randomize the hit effect SFX parameters
                RandomizeAll(paramDict["HitEffectSfxParam"].Rows);

                // Get the melee (including shields), ranged and magic weapons seperately
                PARAM param = paramDict["EquipParamWeapon"];
                var meleeWeapons = param.Rows.Where(row => row.ID <= 32301200);
                var magicWeapons = param.Rows.Where(row => row.ID > 32301200 && row.ID <= 34090000);
                var rangedWeapons = param.Rows.Where(row => row.ID > 34090000);
                RandomizeSome(param.Rows,
                    "correctStrength", 
                    "correctAgility", 
                    "correctMagic", 
                    "correctFaith",
                    "correctLuck",

                    "slashGuardCutRate",
                    "blowGuardCutRate",
                    "thrustGuardCutRate",
                    "poisonGuardResist",
                    "diseaseGuardResist",
                    "bloodGuardResist",
                    "curseGuardResist",

                    "residentSpEffectId0", 
                    "residentSpEffectId1", 
                    "residentSpEffectId2", 

                    "parryDamageLife",
                    "attackBasePhysics",
                    "attackBaseMagic",
                    "attackBaseFire",
                    "attackBaseThunder",
                    "attackBaseStamina", 

                    "saWeaponDamage", 
                    "saDurability",
                    //"throwAtkRate",
                    //"bowDistRate",
                    "stealthAtkRate",

                    "guardAngle", 
                    "staminaGuardDef", 

                    "properStrength", 
                    "properAgility", 
                    "properMagic", 
                    "properFaith"
                );

                if (randomizeWeaponsWeight)
                    RandomizeSome(param.Rows, "weight");

                // Specific category randomization, this
                // way melee weapons won't act like ranged
                // or magic weapons and vice versa
                string[] weaponParameters = new string[]
                {
                    "wepmotionCategory",
                    "guardmotionCategory",
                    "spAtkcategory",
                    "wepmotionOneHandId",
                    "wepmotionBothHandId",
                    "swordArtsParamId",
                    "wepSeIdOffset"
                };

                if (keepWeaponCategories)
                {
                    RandomizeSome(meleeWeapons, weaponParameters);
                    RandomizeSome(rangedWeapons, weaponParameters);
                    RandomizeSome(magicWeapons, weaponParameters);
                }
                else
                    RandomizeSome(param.Rows, weaponParameters);

                // TODO: This does not work

                //for (int i = 0; i < 24; i++)
                //    RandomizeOne<int>(valid, "HitSfx" + i);
                //for (int i = 0; i < 8; i++)
                //    RandomizeOne<int>(valid, "weaponVfx" + i);
            }

            if (doSpells)
            {
                PARAM param = paramDict["Magic"];
                RandomizeSome(param.Rows,
                    "slotLength", 
                    "maxQuantity",
                    //"enable_multi",

                    "requirementIntellect", 
                    "requirementFaith", 
                    "requirementLuck",

                    "analogDexterityMin", 
                    "analogDexterityMax", 

                    "spEffectCategory",
                    "refType",
                    "castSfxId",
                    "fireSfxId",
                    "effectSfxId"
                );
                
                for (int i = 0; i < spellEffectSlots; i++) 
                    RandomizePair<byte, int>(param.Rows, $"refCategory{i + 1}", $"refId{i + 1}");
            }

            if (doHumans)
            {
                PARAM param = paramDict["CharaInitParam"];
                RandomizeSome(param.Rows, 
                    "equip_Helm", 
                    "equip_Armer", 
                    "equip_Gaunt", 
                    "equip_Leg", 
                    "equip_Arrow",
                    "equip_SubArrow",
                    "equip_Bolt",
                    "equip_SubBolt",
                    "equip_Wep_Right", 
                    "equip_Subwep_Right", 
                    "equip_Wep_Left",
                    "equip_Subwep_Left",
                    "equip_Accessory01", 
                    "equip_Accessory02", 
                    "equip_Accessory03", 
                    "equip_Accessory04",

                    "gestureId0",
                    "gestureId1",
                    "gestureId2",
                    "gestureId3",
                    "gestureId4",
                    "gestureId5",
                    "gestureId6",

                    "bodyScaleHead", 
                    "bodyScaleBreast", 
                    "BodyScaleAbdomen", 
                    "BodyScaleArm", 
                    "BodyScaleLeg"
                );
            }

            //{
            //    PARAM param = paramDict["NpcParam"];
            //    foreach (var cell in param.Rows[0].Cells)
            //    {
            //        if (paramName != "teamType" && !paramName.StartsWith("ModelDispMask"))
            //            RandomizeSome(param.Rows, paramName);
            //    }
            //}

            if (doOthers)
            {
                //RandomizeAll(paramDict["AtkParam_Npc"].Rows);
                //RandomizeAll(paramDict["AtkParam_Pc"].Rows);
                //RandomizeAll(paramDict["AttackElementCorrectParam"].Rows);
                //RandomizeAll(paramDict["BehaviorParam"].Rows);
                //RandomizeAll(paramDict["BehaviorParam_PC"].Rows);
                //RandomizeAll(paramDict["DecalParam"].Rows);
                RandomizeAll(paramDict["HitEffectSfxConceptParam"].Rows);
                RandomizeAll(paramDict["SwordArtsParam"].Rows);
                //RandomizeAll(paramDict["ModelSfxParam"].Rows);
                //RandomizeAll(paramDict["NpcThinkParam"].Rows);
                //RandomizeAll(paramDict["ObjectMaterialSfxParam"].Rows);
                RandomizeAll(paramDict["PhantomParam"].Rows);
                //RandomizeAll(paramDict["UpperArmParam"].Rows);
                //RandomizeAll(paramDict["WepAbsorpPosParam"].Rows);
                RandomizeAll(paramDict["WetAspectParam"].Rows);

                // Randomize weather
                {
                    PARAM param = paramDict["WeatherParam"];
                    List<string> valid = param.Rows.First().Cells.Select(cell => cell.Def.InternalName).ToList();

                    // TODO: These properties will all crash when used
                    //       in the method RandomizeOne. I've noticed all the
                    //       unsupported properties feature a (:numeric) suffix
                    //       in their names in the layout files.
                    //       However I don't know what this suffix means or how
                    //       to support it -- so let's just ignore these properties
                    List<string> elementsToRemove = new List<string>
                    {
                        "GparamId",
                        "NextLotIngameSecondsMin",
                        "NextLotIngameSecondsMax"
                    };
                    valid.RemoveAll(element => elementsToRemove.Contains(element));

                    RandomizeSome(
                        param.Rows,
                        valid.ToArray()
                    );
                }

                // Randomize decals
                {
                    PARAM param = paramDict["DecalParam"];
                    List<string> valid = param.Rows.First().Cells.Select(cell => cell.Def.InternalName).ToList();

                    // TODO: These properties will all crash when used
                    //       in the method RandomizeOne. I've noticed all the
                    //       unsupported properties feature a (:numeric) suffix
                    //       in their names in the layout files.
                    //       However I don't know what this suffix means or how
                    //       to support it -- so let's just ignore these properties
                    List<string> elementsToRemove = new List<string>
                    {
                        "pad_05",
                        "pad_08",
                        "pad_09",
                        "pad_10",
                        "pad_11",
                        "pad_12",
                        "useDeferredDecal",
                        "usePaintDecal",
                        "useEmissive",
                        "putVertical",
                        "replaceTextureId_byMaterial",
                        "dmypolyCategory",
                        "bloodTypeEnable",
                        "bUseNormal",
                        "usePom",
                        "randVaria_Normal",
                        "randVaria_Height",
                        "randVaria_Emissive",
                        "randVaria_Diffuse",
                        "randVaria_Mask",
                        "randVaria_Reflec",
                        "thinOutOverlapLimitNum",
                        "thinOutNeighborLimitNum"
                    };
                    valid.RemoveAll(element => elementsToRemove.Contains(element));

                    RandomizeSome(
                        param.Rows,
                        valid.ToArray()
                    );
                }
            }
        }

        // TODO: I do not know how to figure out the correct categories
        //       for elden ring, therefore I will not use these values
        //       as they are from the original DS3 irregulator
        private static byte[] weaponCats = { 0, 1, 2, 3, 4, 5, 6, 7, 9, 12 };
        private static byte[] bowCats = { 10, 11 };
        private static byte[] ammoCats = { 13, 14 };
        private static byte[] catalystCats = { 8 };

        private void RandomizeOne<T>(IEnumerable<PARAM.Row> rows, string param, bool plusMode = false)
        {
            if (plusMode)
            {
                List<T> options = rows.Select(row => (T)row[param].Value).GroupBy(val => val).Select(group => group.First()).ToList();
                foreach (PARAM.Row row in rows)
                    row[param].Value = options.GetRandom(rand);
            }
            else
            {
                List<T> options = new List<T>(rows.Select(row => (T)row[param].Value));
                foreach (PARAM.Row row in rows)
                    row[param].Value = options.PopRandom(rand);
            }
        }

        private void RandomizePair<T1, T2>(IEnumerable<PARAM.Row> rows, string param1, string param2)
        {
            List<(T1, T2)> options = rows.Select(row => ((T1)row[param1].Value, (T2)row[param2].Value)).ToList();
            foreach (PARAM.Row row in rows)
            {
                (T1 val1, T2 val2) = options.PopRandom(rand);
                row[param1].Value = val1;
                row[param2].Value = val2;
            }
        }

        private void RandomizeSome(IEnumerable<PARAM.Row> rows, params string[] paramNames)
        {
            foreach (string paramName in paramNames)
            {
                var cells = new List<PARAM.Cell>(rows.First().Cells);
                var cell = cells.Find(c => c.Def.InternalName == paramName);
                if (cell == null
                ||  cell == default(PARAM.Cell))
                    return;

                string cellName = cell.Def.InternalName;
                switch (cell.Def.DisplayType)
                {
                    case PARAMDEF.DefType.u8:
                        RandomizeOne<byte>(rows, cellName);
                        break;
                    case PARAMDEF.DefType.s8:
                        RandomizeOne<sbyte>(rows, cellName);
                        break;
                    case PARAMDEF.DefType.u16:
                        RandomizeOne<ushort>(rows, cellName);
                        break;
                    case PARAMDEF.DefType.s16:
                        RandomizeOne<short>(rows, cellName);
                        break;
                    case PARAMDEF.DefType.u32:
                        RandomizeOne<short>(rows, cellName);
                        break;
                    case PARAMDEF.DefType.s32:
                        RandomizeOne<int>(rows, cellName);
                        break;
                    case PARAMDEF.DefType.f32:
                        RandomizeOne<float>(rows, cellName);
                        break;
                    case PARAMDEF.DefType.b32:
                        RandomizeOne<bool>(rows, cellName);
                        break;
                }
            }
        }

        private void RandomizeAll(IEnumerable<PARAM.Row> rows, bool plusMode = false)
        {
            foreach (PARAM.Cell cell in rows.First().Cells)
            {
                string cellName = cell.Def.InternalName;
                switch (cell.Def.DisplayType) {
                    case PARAMDEF.DefType.u8:
                        RandomizeOne<byte>(rows, cellName, plusMode);
                        break;
                    case PARAMDEF.DefType.s8:
                        RandomizeOne<sbyte>(rows, cellName, plusMode);
                        break;
                    case PARAMDEF.DefType.u16:
                        RandomizeOne<ushort>(rows, cellName, plusMode);
                        break;
                    case PARAMDEF.DefType.s16:
                        RandomizeOne<short>(rows, cellName, plusMode);
                        break;
                    case PARAMDEF.DefType.u32:
                        RandomizeOne<short>(rows, cellName, plusMode);
                        break;
                    case PARAMDEF.DefType.s32:
                        RandomizeOne<int>(rows, cellName, plusMode);
                        break;
                    case PARAMDEF.DefType.f32:
                        RandomizeOne<float>(rows, cellName, plusMode);
                        break;
                    case PARAMDEF.DefType.b32:
                        RandomizeOne<bool>(rows, cellName, plusMode);
                        break;
                }
            }
        }
    }
}
