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
            Dictionary<string, PARAM> paramDict,
            bool doArmor, 
                bool randomizeArmorWeight,
            bool doWeapons, 
                bool randomizeWeaponsWeight,
                bool randomizeWeaponAttributes,
                bool keepWeaponCategories, bool seperateShieldsFromMeleeWeapons,
                bool keepWeaponMovesets,
                bool keepWeaponArtsOfWar,
            bool doRings, 
                bool randomizeRingsWeight,
            bool doGoods, 
            bool doSpells,
            bool doBullets, 
                bool bulletsPlus, 
            bool doHumans, 
            bool doOthers
        )
        {
            if (doBullets)
            {
                PARAM param = paramDict["Bullet"];

                // Remove the assetNo_Hit parameter, as from my experience
                // randomizing this will mostly always spawn poles when bullets are
                // created which will obstruct the player and definitely make
                // the game crash
                RandomizeAllExcept(param.Rows, bulletsPlus,
                    "assetNo_Hit"
                );
            }

            if (doRings)
            {
                PARAM param = paramDict["EquipParamAccessory"];
                RandomizeSome(param.Rows, false,
                    "spEffectCategory",
                    "sfxVariationId",
                    "behaviorId",
                    "residentSpEffectId1",
                    "residentSpEffectId2",
                    "residentSpEffectId3",
                    "residentSpEffectId4"
                );
                RandomizePair<byte, int>(param.Rows, "refCategory", "refId");

                if (randomizeRingsWeight)
                    RandomizeSome(param.Rows, false, "weight");
            }

            if (doGoods)
            {
                PARAM param = paramDict["EquipParamGoods"];

                // Skip flasks of tears, wondrous physicks and
                // other important items
                int ceruleanFlaskStart = 1000;
                int ceruleanFlaskEnd = 1075;
                int wondrousFlaskStart = 250;
                int wondrousFlaskEnd = 251;
                int spiritCallingBell = 8158;
                // There exist two entries for the spectral steed
                // whistle, let's just exclude both of them
                int[] spectralSteedWhistles = new int[] { 130, 181 };
                var usable = param.Rows.Where(
                    row =>
                       !(row.ID >= ceruleanFlaskStart
                    &&   row.ID <= ceruleanFlaskEnd)

                    && !(row.ID >= wondrousFlaskStart
                    &&   row.ID <= wondrousFlaskEnd)

                    &&  !spectralSteedWhistles.Any((id) => id == row.ID)
                    &&   row.ID != spiritCallingBell
                );

                RandomizeSome(usable, false,
                    "sfxVariationId",
                    "castSfxId",
                    "fireSfxId",
                    "effectsSfxId",
                    "goodsUseAnim",
                    "goodsType",
                    "behaviorId"
                );
                RandomizePair<byte, int>(usable, "refCategory", "refId_default");
                RandomizePair<byte, int>(usable, "spEffectCategory", "refId_1");
            }

            if (doArmor)
            {
                PARAM param = paramDict["EquipParamProtector"];
                var valid = param.Rows.Where(row => row.ID >= 40000);
                RandomizeSome(valid, false,
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
                    RandomizeSome(valid, false, "weight");
            }

            if (doWeapons)
            {
                // Always randomize the hit effect SFX parameters
                RandomizeAll(paramDict["HitEffectSfxParam"].Rows);

                // Get the melee (including shields), ranged and magic weapons seperately;
                // Also skip the unarmed weapon.
                PARAM param = paramDict["EquipParamWeapon"];
                IEnumerable<PARAM.Row> weaponsExceptUnarmed = param.Rows.Where(row => row.ID >  110000);
                IEnumerable<PARAM.Row> meleeWeapons         = param.Rows.Where(row => row.ID >  110000   && row.ID <= 24510000);
                IEnumerable<PARAM.Row> shieldMeleeWeapons   = param.Rows.Where(row => row.ID >= 30000000 && row.ID <= 32520000);
                IEnumerable<PARAM.Row> magicWeapons         = param.Rows.Where(row => row.ID >= 33000000 && row.ID <= 34520000);
                IEnumerable<PARAM.Row> rangedWeapons        = param.Rows.Where(row => row.ID >= 40000000);
                RandomizeSome(param.Rows, false,
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

                // Setup specific weapon parameters for filtering purposes
                string[] weaponAttributeParameters = new string[2]
                {
                    "spAtkcategory",
                    "spAttribute"
                };
                string[] weaponMovesetParameters = new string[4] { 
                    "wepmotionCategory",
                    "wepmotionOneHandId",
                    "wepmotionBothHandId",
                    "guardmotionCategory"
                };
                string[] weaponArtsOfWarParameters = new string[1] {
                    "swordArtsParamId"
                };
                string[] weaponWeightParameters = new string[1] {
                    "weight"
                };

                // Setup total weapon parameter list based on filters
                List<string> weaponParametersList = new List<string>()
                {
                    "wepSeIdOffset"
                };
                if (randomizeWeaponsWeight)
                    weaponParametersList.AddRange(weaponWeightParameters);
                if (randomizeWeaponAttributes)
                    weaponParametersList.AddRange(weaponAttributeParameters);
                if (!keepWeaponMovesets)
                    weaponParametersList.AddRange(weaponMovesetParameters);
                if (!keepWeaponArtsOfWar)
                    weaponParametersList.AddRange(weaponArtsOfWarParameters);
                string[] weaponParameters = weaponParametersList.ToArray();

                // Randomize based on if the categories should be kept or not
                if (keepWeaponCategories)
                {
                    if (seperateShieldsFromMeleeWeapons)
                    {
                        RandomizeSome(meleeWeapons, false, weaponParameters);
                        RandomizeSome(shieldMeleeWeapons, false, weaponParameters);
                    }
                    else
                    {
                        IEnumerable<PARAM.Row> allMeleeWeapons = meleeWeapons.Concat(shieldMeleeWeapons);
                        RandomizeSome(allMeleeWeapons, false, weaponParameters);
                    }

                    RandomizeSome(rangedWeapons, false, weaponParameters);
                    RandomizeSome(magicWeapons, false, weaponParameters);
                }
                else
                    RandomizeSome(weaponsExceptUnarmed, false, weaponParameters);

                // Randomize arts of war
                if (!keepWeaponArtsOfWar)
                    RandomizeAll(paramDict["SwordArtsParam"].Rows);
            }

            if (doSpells)
            {
                PARAM param = paramDict["Magic"];
                RandomizeSome(param.Rows, false,
                    "slotLength", 
                    "maxQuantity",
                    "enable_multi",

                    "mp",
                    "stamina",

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

                for (int i = 0; i < 10; i++)
                {
                    RandomizeSome(param.Rows, false, $"consumeType{i + 1}");
                    RandomizePair<byte, int>(param.Rows, $"refCategory{i + 1}", $"refId{i + 1}");
                }
            }

            if (doHumans)
            {
                PARAM param = paramDict["CharaInitParam"];
                RandomizeSome(param.Rows, false,
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
                RandomizeAll(paramDict["FootSfxParam"].Rows);
                RandomizeAll(paramDict["PhantomParam"].Rows);
                RandomizeAll(paramDict["WetAspectParam"].Rows);
                RandomizeAll(paramDict["WeatherParam"].Rows);
            }
        }

        private void RandomizeSome(IEnumerable<PARAM.Row> rows, bool plusMode, params string[] paramNames)
        {
            var cells = new List<PARAM.Cell>(rows.First().Cells);
            foreach (string paramName in paramNames)
            {
                var cell = cells.Find(c => c.Def.InternalName == paramName);
                if (cell == null
                ||  cell == default(PARAM.Cell))
                    return;

                RandomizeCell(rows, cell, plusMode);
            }
        }

        private void RandomizeAll(IEnumerable<PARAM.Row> rows, bool plusMode = false)
        {
            foreach (PARAM.Cell cell in rows.First().Cells)
                RandomizeCell(rows, cell, plusMode);
        }

        private void RandomizeAllExcept(IEnumerable<PARAM.Row> rows, bool plusMode, params string[] except)
        {
            List<string> paramNames = rows.First().Cells.Select(cell => cell.Def.InternalName).ToList();
            paramNames.RemoveAll(paramName => except.Contains(paramName));
            RandomizeSome(rows, plusMode, paramNames.ToArray());
        }
    
        private void RandomizeCell(IEnumerable<PARAM.Row> rows, PARAM.Cell cell, bool plusMode = false)
        {
            switch (cell.Def.DisplayType)
            {
                case PARAMDEF.DefType.u8:
                    RandomizeOne<byte>(rows, cell.Def.InternalName, plusMode);
                    break;
                case PARAMDEF.DefType.s8:
                    RandomizeOne<sbyte>(rows, cell.Def.InternalName, plusMode);
                    break;
                case PARAMDEF.DefType.u16:
                    RandomizeOne<ushort>(rows, cell.Def.InternalName, plusMode);
                    break;
                case PARAMDEF.DefType.s16:
                    RandomizeOne<short>(rows, cell.Def.InternalName, plusMode);
                    break;
                case PARAMDEF.DefType.u32:
                    RandomizeOne<uint>(rows, cell.Def.InternalName, plusMode);
                    break;
                case PARAMDEF.DefType.s32:
                    RandomizeOne<int>(rows, cell.Def.InternalName, plusMode);
                    break;
                case PARAMDEF.DefType.f32:
                    RandomizeOne<float>(rows, cell.Def.InternalName, plusMode);
                    break;
                case PARAMDEF.DefType.b32:
                    RandomizeOne<bool>(rows, cell.Def.InternalName, plusMode);
                    break;
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
    }
}
