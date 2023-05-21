using SoulsFormats;
using System;
using System.Collections.Generic;
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

                // Skip flasks of tears, wondrous physicks and
                // spectral steed whistle
                int ceruleanFlaskStart = 1000;
                int ceruleanFlaskEnd = 1075;
                int wondrousFlaskStart = 250;
                int wondrousFlaskEnd = 251;
                int spectralSteedWhistle = 130;
                var usable = param.Rows.Where(
                    row =>
                       !(row.ID >= ceruleanFlaskStart
                    &&   row.ID <= ceruleanFlaskEnd)
                    && !(row.ID >= wondrousFlaskStart
                    &&   row.ID <= wondrousFlaskEnd)
                    &&   row.ID != spectralSteedWhistle
                );

                RandomizeSome(usable,
                    "sfxVariationId",
                    "effectsSfxId",
                    "castSfxId",
                    "fireSfxId",
                    "goodsUseAnim",
                    "behaviorId",
                    "spEffectCategory"
                );
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

                    "properStrength",
                    "properAgility",
                    "properMagic",
                    "properFaith",
                    "properLuck",

                    "physGuardCutRate",
                    "magGuardCutRate",
                    "fireGuardCutRate",
                    "thunGuardCutRate",
                    "slashGuardCutRate",
                    "blowGuardCutRate",
                    "thrustGuardCutRate",
                    "poisonGuardResist",
                    "diseaseGuardResist",
                    "bloodGuardResist",
                    "curseGuardResist",
                    "sleepGuardResist",
                    "madnessGuardResist",
                    "freezeGuardResist",

                    "spEffectBehaviorId0",
                    "spEffectBehaviorId1",
                    "spEffectBehaviorId2",
                    "residentSpEffectId",
                    "residentSpEffectId1",
                    "residentSpEffectId2",

                    "parryDamageLife",
                    "attackBasePhysics",
                    "attackBaseMagic",
                    "attackBaseDark",
                    "attackBaseFire",
                    "attackBaseThunder",
                    "attackBaseStamina",

                    "saWeaponDamage", 
                    "durabilityMax",
                    //"throwAtkRate",
                    //"bowDistRate",
                    "stealthAtkRate",

                    "guardAngle", 
                    "staminaGuardDef"
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
                    "spAttribute",
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
                    "equip_Subwep_Left"
                );
            }

            // This will absolutely break NPC behaviour
            //{
            //    PARAM param = paramDict["NpcParam"];
            //    foreach (var cell in param.Rows[0].Cells)
            //    {
            //        string paramName = cell.Def.InternalName;
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
                //RandomizeAll(paramDict["ModelSfxParam"].Rows);
                //RandomizeAll(paramDict["NpcThinkParam"].Rows);
                //RandomizeAll(paramDict["ObjectMaterialSfxParam"].Rows);
                //RandomizeAll(paramDict["UpperArmParam"].Rows);
                //RandomizeAll(paramDict["WepAbsorpPosParam"].Rows);

                RandomizeAll(paramDict["DecalParam"].Rows);
                RandomizeAll(paramDict["HitEffectSfxConceptParam"].Rows);
                RandomizeAll(paramDict["SwordArtsParam"].Rows);
                RandomizeAll(paramDict["FootSfxParam"].Rows);
                RandomizeAll(paramDict["PhantomParam"].Rows);
                RandomizeAll(paramDict["WetAspectParam"].Rows);
                RandomizeAll(paramDict["WeatherParam"].Rows);
            }
        }

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
                        RandomizeOne<uint>(rows, cellName);
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
                        RandomizeOne<uint>(rows, cellName, plusMode);
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
