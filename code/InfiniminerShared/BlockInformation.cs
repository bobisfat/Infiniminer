using System;
using System.Collections.Generic;

using System.Text;

namespace Infiniminer
{
    public enum ItemType : byte
    {
        None,
        Gold,
        Ore,
        Artifact,
        MAXIMUM
    }

    public enum BlockType : byte
    {
        None,
        Dirt,
        Mud,
        Sand,
        Ore,
        Gold,
        Diamond,
        Rock,
        Ladder,
        Explosive,
        Jump,
        Shock,
        ArtCaseR,
        ArtCaseB,
        BankRed,
        BankBlue,
        BaseRed,
        BaseBlue,
        BeaconRed,
        BeaconBlue,
        Road,
        SolidRed,
        SolidBlue,
        SolidRed2,
        SolidBlue2,
        Metal,
        DirtSign,
        Lava,
        Generator,
        Controller,
        Pump,
        Compressor,
        Pipe,
        TransRed,
        TransBlue,
        Water,
        Spring,
        MagmaVent,
        Fire,
        Vacuum,
        TrapB,
        TrapR,
        StealthBlockR,
        StealthBlockB,
        Magma,
        Lever,
        Plate,
        RadarRed,
        RadarBlue,
        Hinge,
        Highlight,//purely for particle effect
        ConstructionR,//a temporary block for difficult-to-make blocks
        ConstructionB,
        GlassR,
        GlassB,
        ForceR,
        ForceB,
        MAXIMUM
    }

    public enum BlockTexture : byte
    {
        None,
        Dirt,
        Mud,
        Sand,
        Ore,
        Gold,
        Diamond,
        Rock,
        Jump,
        JumpTop,
        Ladder,
        LadderTop,
        Explosive,
        Spikes,
        HomeRed,
        HomeBlue,
        BankTopRed,
        BankTopBlue,
        BankFrontRed,
        BankFrontBlue,
        BankLeftRed,
        BankLeftBlue,
        BankRightRed,
        BankRightBlue,
        BankBackRed,
        BankBackBlue,
        BaseTopRed,
        BaseTopBlue,
        BaseFrontRed,
        BaseFrontBlue,
        BaseLeftRed,
        BaseLeftBlue,
        BaseRightRed,
        BaseRightBlue,
        BaseBackRed,
        BaseBackBlue,
        TeleTop,
        TeleBottom,
        TeleSideA,
        TeleSideB,
        SolidRed,
        SolidBlue,
        SolidRed2,
        SolidBlue2,
        Metal,
        DirtSign,
        Lava,
        Generator,
        Controller,
        Pump,
        Compressor,
        Pipe,
        Road,
        RoadTop,
        RoadBottom,
        BeaconRed,
        BeaconBlue,
        Spring,
        MagmaVent,
        Fire,
        Water,
        Magma,
        TrapR,
        TrapB,
        TrapVis,
        Trap,
        StealthBlockR,
        StealthBlockB,
        Lever,
        Plate,
        TransRed,   // THESE MUST BE THE LAST TWO TEXTURES
        TransBlue,
        RadarRed,
        RadarBlue,
        Hinge,
        Construction,
        GlassR,
        GlassB,
        ArtCaseR,
        ArtCaseB,
        ForceR,
        ForceB,
        MAXIMUM
    }

    public enum BlockFaceDirection : byte
    {
        XIncreasing,
        XDecreasing,
        YIncreasing,
        YDecreasing,
        ZIncreasing,
        ZDecreasing,
        MAXIMUM
    }

    public class BlockInformation
    {
        static int[] blockHP = new int[256];
        static int[] blockMaxHP = new int[256];

        static BlockInformation()
        {
            for (int a = 0; a < 255; a++)
            {
                blockHP[a] = 10;
                blockMaxHP[a] = 30;
            }

            blockMaxHP[(byte)BlockType.Water] = 0;
            blockMaxHP[(byte)BlockType.Lava] = 0;
            blockMaxHP[(byte)BlockType.Spring] = 0;
            blockMaxHP[(byte)BlockType.MagmaVent] = 0;
            blockMaxHP[(byte)BlockType.Magma] = 0;
            blockMaxHP[(byte)BlockType.Fire] = 0;
            blockMaxHP[(byte)BlockType.BaseBlue] = 0;
            blockMaxHP[(byte)BlockType.BaseRed] = 0;
            blockMaxHP[(byte)BlockType.Vacuum] = 0;
            blockMaxHP[(byte)BlockType.Sand] = 0;
            blockMaxHP[(byte)BlockType.Dirt] = 0;
            blockMaxHP[(byte)BlockType.Ore] = 0;
            blockMaxHP[(byte)BlockType.Rock] = 0;
            blockMaxHP[(byte)BlockType.ForceR] = 0;
            blockMaxHP[(byte)BlockType.ForceB] = 0;

            blockHP[(byte)BlockType.ConstructionR] = 100;
            blockMaxHP[(byte)BlockType.ConstructionR] = 200;
            blockHP[(byte)BlockType.ConstructionB] = 100;
            blockMaxHP[(byte)BlockType.ConstructionB] = 200;

            blockHP[(byte)BlockType.Gold] = 80;
            blockMaxHP[(byte)BlockType.Gold] = 80;
            blockHP[(byte)BlockType.Metal] = 50;
            blockMaxHP[(byte)BlockType.Metal] = 1;//non-repairable

            blockHP[(byte)BlockType.GlassR] = 10;
            blockMaxHP[(byte)BlockType.GlassR] = 50;

            blockHP[(byte)BlockType.GlassB] = 10;
            blockMaxHP[(byte)BlockType.GlassB] = 50;

            blockHP[(byte)BlockType.ArtCaseR] = 50;
            blockMaxHP[(byte)BlockType.ArtCaseR] = 200;

            blockHP[(byte)BlockType.ArtCaseB] = 50;
            blockMaxHP[(byte)BlockType.ArtCaseB] = 200;

            blockMaxHP[(byte)BlockType.SolidRed] = 50;
            blockMaxHP[(byte)BlockType.SolidBlue] = 50;

            blockHP[(byte)BlockType.SolidRed2] = 50;
            blockMaxHP[(byte)BlockType.SolidRed2] = 100;

            blockHP[(byte)BlockType.SolidBlue2] = 50;
            blockMaxHP[(byte)BlockType.SolidBlue2] = 100;

        }

        public static int GetHP(BlockType blockType)
        {
            return blockHP[(byte)blockType];
        }

        public static int GetMaxHP(BlockType blockType)
        {
            return blockMaxHP[(byte)blockType];
        }
        //    switch (blockType)
        //    {
        //        case BlockType.RadarRed:
        //        case BlockType.RadarBlue:
        //        case BlockType.BankRed:
        //        case BlockType.BankBlue:
        //        case BlockType.BeaconRed:
        //        case BlockType.BeaconBlue:
        //        case BlockType.Lever:
        //        case BlockType.Hinge:
        //        case BlockType.Water:
        //        case BlockType.Generator:
        //        case BlockType.Controller:
        //        case BlockType.Pump:
        //        case BlockType.Compressor:
        //        case BlockType.Lava:
        //        case BlockType.Dirt:
        //        case BlockType.Pipe:
        //        case BlockType.StealthBlockB:
        //        case BlockType.StealthBlockR:
        //        case BlockType.TrapB:
        //        case BlockType.TrapR:
        //        case BlockType.TransRed:
        //        case BlockType.TransBlue:
        //        case BlockType.Road:
        //        case BlockType.Jump:
        //        case BlockType.Ladder:
        //        case BlockType.Shock:
        //        case BlockType.Explosive:
        //            return 10;

        //        case BlockType.SolidRed:
        //        case BlockType.SolidBlue:
        //            return 10;

        //        case BlockType.SolidRed2:
        //        case BlockType.SolidBlue2:
        //            return 50;
        //    }

        //    return 10;
        //}
       
        public static uint GetCost(BlockType blockType)
        {
            switch (blockType)
            {
                case BlockType.RadarRed:
                case BlockType.RadarBlue:
                    return 200;
                case BlockType.ArtCaseR:
                case BlockType.ArtCaseB:
                case BlockType.BankRed:
                case BlockType.BankBlue:
                    return 200;
                case BlockType.BeaconRed:
                case BlockType.BeaconBlue:
                case BlockType.Lever:
                case BlockType.Plate:
                case BlockType.Hinge:
                case BlockType.SolidRed:
                case BlockType.SolidBlue:
                    return 50;
                case BlockType.Water:
                case BlockType.Generator:
                case BlockType.Controller:
                case BlockType.Pump:
                case BlockType.Compressor:
                case BlockType.Lava:
                case BlockType.Dirt:
                case BlockType.Pipe:
                case BlockType.StealthBlockB:
                case BlockType.StealthBlockR:
                case BlockType.TrapB:
                case BlockType.TrapR:
                case BlockType.ConstructionR:
                case BlockType.ConstructionB:
                    return 10;

                case BlockType.Metal:
                case BlockType.TransRed:
                case BlockType.TransBlue:
                    return 25;

                case BlockType.Road:
                    return 10;
                case BlockType.Jump:
                    return 25;
                case BlockType.Ladder:
                    return 25;
                case BlockType.Shock:
                    return 50;
                case BlockType.Explosive:
                case BlockType.GlassR:
                case BlockType.GlassB:
                    return 100;
            }

            return 1000;
        }

        public static BlockTexture GetTexture(BlockType blockType, BlockFaceDirection faceDir)
        {
            return GetTexture(blockType, faceDir, BlockType.None);
        }

        public static BlockTexture GetTexture(BlockType blockType, BlockFaceDirection faceDir, BlockType blockAbove)
        {
            switch (blockType)
            {
                case BlockType.Generator:
                    return BlockTexture.Generator;
                case BlockType.Controller:
                    return BlockTexture.Controller;
                case BlockType.Pump:
                    return BlockTexture.Pump;
                case BlockType.Compressor:
                    return BlockTexture.Compressor;
                case BlockType.Hinge:
                    return BlockTexture.Hinge;
                case BlockType.Pipe:
                    return BlockTexture.Pipe;
                case BlockType.Metal:
                    return BlockTexture.Metal;
                case BlockType.Dirt:
                    return BlockTexture.Dirt;
                case BlockType.Mud:
                    return BlockTexture.Mud;
                case BlockType.Sand:
                    return BlockTexture.Sand;
                case BlockType.Lava:
                    return BlockTexture.Lava;
                case BlockType.Water:
                    return BlockTexture.Water;
                case BlockType.Rock:
                    return BlockTexture.Rock;
                case BlockType.Spring:
                    return BlockTexture.Spring;
                case BlockType.MagmaVent:
                    return BlockTexture.MagmaVent;
                case BlockType.Fire:
                    return BlockTexture.Fire;
                case BlockType.Ore:
                    return BlockTexture.Ore;
                case BlockType.Gold:
                    return BlockTexture.Gold;
                case BlockType.Diamond:
                    return BlockTexture.Diamond;
                case BlockType.Lever:
                    return BlockTexture.Lever;
                case BlockType.Plate:
                    return BlockTexture.Lever;
                case BlockType.DirtSign:
                    return BlockTexture.DirtSign;
                case BlockType.Magma:
                    return BlockTexture.Magma;
                case BlockType.StealthBlockR:
                    return BlockTexture.StealthBlockR;
                case BlockType.StealthBlockB:
                    return BlockTexture.StealthBlockB;
                case BlockType.TrapB:
                    return BlockTexture.TrapB;
                case BlockType.TrapR:
                   return BlockTexture.TrapR;
                case BlockType.ConstructionR:
                case BlockType.ConstructionB:
                   return BlockTexture.Construction;
                case BlockType.GlassR:
                   return BlockTexture.GlassR;
                case BlockType.GlassB:
                   return BlockTexture.GlassB;
                case BlockType.ForceR:
                   return BlockTexture.ForceR;
                case BlockType.ForceB:
                   return BlockTexture.ForceB;
                case BlockType.ArtCaseR:
                   switch (faceDir)
                   {
                       case BlockFaceDirection.XIncreasing: return BlockTexture.ArtCaseR;
                       case BlockFaceDirection.XDecreasing: return BlockTexture.BankBackRed;
                       case BlockFaceDirection.ZIncreasing: return BlockTexture.BankLeftRed;
                       case BlockFaceDirection.ZDecreasing: return BlockTexture.BankRightRed;
                       default: return BlockTexture.BankTopRed;
                   }
                case BlockType.ArtCaseB:
                   switch (faceDir)
                   {
                       case BlockFaceDirection.XIncreasing: return BlockTexture.ArtCaseB;
                       case BlockFaceDirection.XDecreasing: return BlockTexture.BankBackBlue;
                       case BlockFaceDirection.ZIncreasing: return BlockTexture.BankLeftBlue;
                       case BlockFaceDirection.ZDecreasing: return BlockTexture.BankRightBlue;
                       default: return BlockTexture.BankTopBlue;
                   }
                case BlockType.BankRed:
                    switch (faceDir)
                    {
                        case BlockFaceDirection.XIncreasing: return BlockTexture.BankFrontRed;
                        case BlockFaceDirection.XDecreasing: return BlockTexture.BankBackRed;
                        case BlockFaceDirection.ZIncreasing: return BlockTexture.BankLeftRed;
                        case BlockFaceDirection.ZDecreasing: return BlockTexture.BankRightRed;
                        default: return BlockTexture.BankTopRed;
                    }

                case BlockType.BankBlue:
                    switch (faceDir)
                    {
                        case BlockFaceDirection.XIncreasing: return BlockTexture.BankFrontBlue;
                        case BlockFaceDirection.XDecreasing: return BlockTexture.BankBackBlue;
                        case BlockFaceDirection.ZIncreasing: return BlockTexture.BankLeftBlue;
                        case BlockFaceDirection.ZDecreasing: return BlockTexture.BankRightBlue;
                        default: return BlockTexture.BankTopBlue;
                    }

                case BlockType.BaseRed:
                    switch (faceDir)
                    {
                        case BlockFaceDirection.XIncreasing: return BlockTexture.BankFrontRed;
                        case BlockFaceDirection.XDecreasing: return BlockTexture.BankBackRed;
                        case BlockFaceDirection.ZIncreasing: return BlockTexture.BankLeftRed;
                        case BlockFaceDirection.ZDecreasing: return BlockTexture.BankRightRed;
                        default: return BlockTexture.BankTopRed;
                    }

                case BlockType.BaseBlue:
                    switch (faceDir)
                    {
                        case BlockFaceDirection.XIncreasing: return BlockTexture.BankFrontBlue;
                        case BlockFaceDirection.XDecreasing: return BlockTexture.BankBackBlue;
                        case BlockFaceDirection.ZIncreasing: return BlockTexture.BankLeftBlue;
                        case BlockFaceDirection.ZDecreasing: return BlockTexture.BankRightBlue;
                        default: return BlockTexture.BankTopBlue;
                    }

                case BlockType.RadarRed:
                case BlockType.RadarBlue:
                    switch (faceDir)
                    {
                        case BlockFaceDirection.YDecreasing:
                            return BlockTexture.LadderTop;
                        case BlockFaceDirection.YIncreasing:
                            return blockType == BlockType.RadarRed ? BlockTexture.BeaconRed : BlockTexture.BeaconBlue;
                        case BlockFaceDirection.XDecreasing:
                        case BlockFaceDirection.XIncreasing:
                            return BlockTexture.TeleSideA;
                        case BlockFaceDirection.ZDecreasing:
                        case BlockFaceDirection.ZIncreasing:
                            return BlockTexture.TeleSideB;
                    }
                    break;

                case BlockType.BeaconRed:
                case BlockType.BeaconBlue:
                    switch (faceDir)
                    {
                        case BlockFaceDirection.YDecreasing:
                            return BlockTexture.LadderTop;
                        case BlockFaceDirection.YIncreasing:
                            return blockType == BlockType.BeaconRed ? BlockTexture.BeaconRed : BlockTexture.BeaconBlue;
                        case BlockFaceDirection.XDecreasing:
                        case BlockFaceDirection.XIncreasing:
                            return BlockTexture.TeleSideA;
                        case BlockFaceDirection.ZDecreasing:
                        case BlockFaceDirection.ZIncreasing:
                            return BlockTexture.TeleSideB;
                    }
                    break;

                case BlockType.Road:
                    if (faceDir == BlockFaceDirection.YIncreasing)
                        return BlockTexture.RoadTop;
                    else if (faceDir == BlockFaceDirection.YDecreasing||blockAbove!=BlockType.None) //Looks better but won't work with current graphics setup...
                        return BlockTexture.RoadBottom;
                    return BlockTexture.Road;

                case BlockType.Shock:
                    switch (faceDir)
                    {
                        case BlockFaceDirection.YDecreasing:
                            return BlockTexture.Spikes;
                        case BlockFaceDirection.YIncreasing:
                            return BlockTexture.TeleBottom;
                        case BlockFaceDirection.XDecreasing:
                        case BlockFaceDirection.XIncreasing:
                            return BlockTexture.TeleSideA;
                        case BlockFaceDirection.ZDecreasing:
                        case BlockFaceDirection.ZIncreasing:
                            return BlockTexture.TeleSideB;
                    }
                    break;

                case BlockType.Jump:
                    switch (faceDir)
                    {
                        case BlockFaceDirection.YDecreasing:
                            return BlockTexture.TeleBottom;
                        case BlockFaceDirection.YIncreasing:
                            return BlockTexture.JumpTop;
                        case BlockFaceDirection.XDecreasing:
                        case BlockFaceDirection.XIncreasing:
                            return BlockTexture.Jump;
                        case BlockFaceDirection.ZDecreasing:
                        case BlockFaceDirection.ZIncreasing:
                            return BlockTexture.Jump;
                    }
                    break;
                case BlockType.SolidRed:
                    return BlockTexture.SolidRed;
                case BlockType.SolidBlue:
                    return BlockTexture.SolidBlue;
                case BlockType.SolidRed2:
                    return BlockTexture.SolidRed2;
                case BlockType.SolidBlue2:
                    return BlockTexture.SolidBlue2;
                case BlockType.TransRed:
                    return BlockTexture.TransRed;
                case BlockType.TransBlue:
                    return BlockTexture.TransBlue;

                case BlockType.Ladder:
                    if (faceDir == BlockFaceDirection.YDecreasing || faceDir == BlockFaceDirection.YIncreasing)
                        return BlockTexture.LadderTop;
                    else
                        return BlockTexture.Ladder;

                case BlockType.Explosive:
                    return BlockTexture.Explosive;
            }

            return BlockTexture.None;
        }
    }
}
