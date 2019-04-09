using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;


class WarCommanderDecodeStrings
{


    public class Class_5
    {
        private int var_2 = 0;

        private int var_3 = 0;

        private readonly List<byte> var_1 = new List<byte>();

        private const uint const_1 = 256;

        public Class_5(BigEndianReader param1) => Method_7(param1);

        private uint Method_9() => const_1;

        private void Method_7(BigEndianReader param1)
        {
            var loc2 = 0;
            var loc3 = 0;
            var loc4 = 0;
            loc2 = 0;
            while (loc2 < 256)
            {
                this.var_1.Add((byte)loc2);
                loc2++;
            }
            loc3 = 0;
            loc2 = 0;
            while (loc2 < 256)
            {
                var array = ((MemoryStream)param1.BaseStream).ToArray();
                loc3 = loc3 + this.var_1[loc2] + array[loc2 % array.Length] & 255;
                loc4 = var_1[loc2];
                var_1[loc2] = var_1[loc3];
                var_1[loc3] = (byte)loc4;
                loc2++;
            }
            var_2 = 0;
            var_3 = 0;
        }

        private uint Method_8()
        {
            var loc1 = 0;
            var_2 = var_2 + 1 & 255;
            var_3 = var_3 + var_1[var_2] & 255;
            loc1 = var_1[var_2];
            var_1[var_2] = var_1[var_3];
            var_1[var_3] = (byte)loc1;
            return var_1[loc1 + var_1[var_2] & 255];
        }

        private uint Method_11() => 1;

        private void Method_4(byte[] param1)
        {
            uint loc2 = 0;
            while (loc2 < param1.Length)
            {
                param1[loc2] = (byte)(param1[loc2] ^ Method_8());
                loc2++;
            }
        }

        public void Method_5(byte[] param1) => Method_4(param1);
    }

    public class Class_2
    {
        private static List<string> var_6 = new List<string>();

        private static List<BigEndianReader> var_4 = new List<BigEndianReader>();

        private static bool var_5 = false;

        private static int var_10;

        private static List<byte[]> resources;

        private static void Method_3()
        {
            var _loc1_ = new BigEndianReader(new MemoryStream(resources[0]));
            var _loc2_ = new BigEndianReader(new MemoryStream(resources[1]));
            var _loc3_ = new BinaryReader(new MemoryStream(resources[2]));
            var_10 = _loc3_.ReadInt32();
            int _loc4_ = _loc2_.ReadByte();
            var _loc5_ = 0;
            while (_loc5_ < _loc4_)
            {
                Method_2(_loc2_);
                _loc5_++;
            }
            _loc1_.BaseStream.Position = 0;
            _loc4_ = _loc1_.ReadInt32();
            var loc6 = 0;
            while (loc6 < _loc4_)
            {
                Method_1(_loc1_, var_4[loc6 % var_4.Count]);
                loc6++;
            }
            var_5 = true;
        }

        private static void Method_1(BigEndianReader param1, BigEndianReader param2)
        {
            int _loc3_ = param1.ReadInt32();
            byte[] _loc4_ = new byte[_loc3_];
            param1.Read(_loc4_, 0, _loc3_);
            var _loc5_ = new Class_5(param2);
            _loc5_.Method_5(_loc4_);
            var reader = new BinaryReader(new MemoryStream(_loc4_));
            byte[] readbytes = new byte[_loc4_.Length];
            reader.Read(readbytes, 0, _loc4_.Length);
            var_6.Add(Encoding.UTF8.GetString(readbytes));
        }

        private static void Method_2(BigEndianReader param1)
        {
            byte[] _loc2_ = param1.ReadBytes(16);
            var_4.Add(new BigEndianReader(new MemoryStream(_loc2_)));
        }

        private static string Method_6(int param1)
        {
            if (!var_5)
                Method_3();
            return var_6[param1 ^ var_10];
        }

        public static string GetDefinitionName(int value, List<byte[]> binaryDatas)
        {
            resources = binaryDatas;
            return Method_6(value);
        }
    }

    public class BigEndianReader : BinaryReader
    {
        public BigEndianReader(Stream input) : base(input) { }

        public override short ReadInt16()
        {
            byte[] b = ReadBytes(2);
            return (short)(b[1] + (b[0] << 8));
        }
        public override int ReadInt32()
        {
            byte[] b = ReadBytes(4);
            return b[3] + (b[2] << 8) + (b[1] << 16) + (b[0] << 24);
        }
        public override long ReadInt64()
        {
            byte[] b = ReadBytes(8);
            return b[7] + (b[6] << 8) + (b[5] << 16) + (b[4] << 24) + (b[3] << 32) + (b[2] << 40) + (b[1] << 48) + (b[0] << 56);
        }

        private bool ReadInt32AsBool()
        {
            byte[] b = ReadBytes(4);
            if (b[0] == 0 || b[1] == 0 || b[2] == 0 || b[3] == 0)
            { return false; }
            else
            { return true; }
        }

        private string ReadString32BitPrefix()
        {
            int length = ReadInt32();
            return Encoding.ASCII.GetString(ReadBytes(length));
        }

        private float ReadFloat() => (float)ReadDouble();

    }

}