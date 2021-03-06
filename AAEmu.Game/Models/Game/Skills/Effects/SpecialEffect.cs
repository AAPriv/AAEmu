using System;
using AAEmu.Game.Models.Game.Skills.Templates;
using AAEmu.Game.Models.Game.Units;

namespace AAEmu.Game.Models.Game.Skills.Effects
{
    public enum SpecialType
    {
        BuffApply = 1,
        SkillStop = 5, // TODO inspect
        Unk1 = 8,
        Unk2 = 9,
        MoveForward = 11,
        MoveBackward = 13,
        DamageEffectApply = 15, // TODO inspect
        BuffSteal = 16,
        Unk3 = 18,
        UnkEffectApply = 19,
        HoldableEnhance = 20, // grade weapeon
        WearableEnhance = 21, // grade equip
        Resurrection = 22,
        Unk4 = 23,
        PetCall = 24,
        Teleport = 25,
        SpecialEffectApply = 27, // TODO inspect
        AddExp = 28,
        Unk5 = 29,
        SavePortal = 30,
        Unk6 = 32,
        SkillUse = 33,
        Unk7 = 34,
        Unk8 = 35,
        Unk9 = 36,
        Unk10 = 37,
        Unk11 = 38,
        Unk12 = 39,
        Unk13 = 40,
        Unk14 = 41,
        AnimPlay = 42, // TODO inspect
        SkillCooldownReset = 43,
        Unk15 = 44,
        ItemUse = 45,
        DamageOnBadBuff = 46,
        Unk16 = 47,
        Unk17 = 48,
        LaborPowerConsume = 49,
        Unk18 = 50,
        PetResurrection = 51,
        Unk19 = 52,
        Unk20 = 53,
        UnderwaterBreath = 54,
        Unk21 = 55,
        PetHpMpRestore = 56,
        Unk22 = 57,
        Unk23 = 58,
        Unk24 = 59,
        Unk25 = 60,
        Unk26 = 61,
        Unk27 = 63,
        CouponReceive = 64,
        ReturnToBase = 65,
        Unk28 = 66,
        Unk29 = 67,
        Unk30 = 68,
        GetCoords = 69,
        Unk31 = 70,
        NationAllianceCreate = 71,
        ShipDestroy = 72,
        Unk32 = 73,
        ReturnToResPoint = 74,
        Complaint = 75,
        Unk33 = 76,
        Unk34 = 77,
        Unk35 = 78,
        Unk36 = 79,
        Unk37 = 81,
        Unk38 = 82,
        Unk39 = 83,
        Unk40 = 84,
        Unk41 = 85,
        Unk42 = 86,
        CraftReputationAdd = 87,
        Petition = 88,
        Arrest = 89,
        PetRecall = 90,
        CreateCharacterCount = 91,
        Unk43 = 92,
        PlayMusic = 93,
        StopMusic = 94,
        WashItem = 95,
        ItemMake = 96,
        WriteMusic = 97,
        DyeItem = 98,
        ReceiveLuluLeaflet = 99,
        Unk44 = 100,
        HairMaker = 101,
        LaborPowerAdd = 102,
        RestoreItemLook = 103,
        Unk45 = 104,
        Unk46 = 105,
        RuneItem = 106,
        GenderChange = 107,
        Unk47 = 108,
        Unk48 = 109
    }
    
    public class SpecialEffect : EffectTemplate
    {
        public SpecialType SpecialEffectTypeId { get; set; } // TODO inspect
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Value3 { get; set; }
        public int Value4 { get; set; }

        public override bool OnActionTime => false;

        public override void Apply(Unit caster, SkillCaster casterObj, BaseUnit target, SkillCastTarget targetObj, CastAction castObj,
            Skill skill, SkillObject skillObject, DateTime time)
        {
            _log.Debug("SpecialEffect");
        }
    }
}
