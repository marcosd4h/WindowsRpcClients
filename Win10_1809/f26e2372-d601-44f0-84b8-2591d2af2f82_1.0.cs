//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\PhoneService.dll
// Interface ID: f26e2372-d601-44f0-84b8-2591d2af2f82
// Interface Version: 1.0



namespace rpc_f26e2372_d601_44f0_84b8_2591d2af2f82_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_1(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_2(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_3(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_4(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_5(Union_6 p0, long p1)
        {
            WriteUnion<Union_6>(p0, p1);
        }
        public void Write_6(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_7(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_8(Struct_9 p0)
        {
            WriteStruct<Struct_9>(p0);
        }
        public void Write_9(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 3);
        }
        public void Write_10(string p0)
        {
            WriteFixedString(p0, 128);
        }
        public void Write_11(string p0)
        {
            WriteFixedString(p0, 64);
        }
        public void Write_12(string p0)
        {
            WriteFixedString(p0, 131);
        }
        public void Write_13(string p0)
        {
            WriteFixedString(p0, 100);
        }
        public void Write_14(string p0)
        {
            WriteFixedString(p0, 80);
        }
        public void Write_15(string p0)
        {
            WriteFixedString(p0, 260);
        }
        public void Write_16(Struct_9[] p0, long p1)
        {
            WriteConformantStructArray<Struct_9>(p0, p1);
        }
        public void Write_17(System.Guid[] p0, long p1)
        {
            WriteConformantArrayCallback<System.Guid>(p0, new System.Action<System.Guid>(this.WriteGuid), p1);
        }
        public void Write_18(NtApiDotNet.Ndr.Marshal.NdrEnum16[] p0, long p1)
        {
            WriteConformantArrayCallback<NtApiDotNet.Ndr.Marshal.NdrEnum16>(p0, new System.Action<NtApiDotNet.Ndr.Marshal.NdrEnum16>(this.WriteEnum16), p1);
        }
        public void Write_19(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_20(string[] p0, long p1)
        {
            WriteConformantStringArray(p0, new System.Action<string>(this.WriteTerminatedString), p1);
        }
        public void Write_21(string p0, long p1)
        {
            WriteConformantVaryingString(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_1 Read_0()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_2 Read_1()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_2()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_3()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_4()
        {
            return ReadStruct<Struct_5>();
        }
        public Union_6 Read_5()
        {
            return ReadStruct<Union_6>();
        }
        public Struct_7 Read_6()
        {
            return ReadStruct<Struct_7>();
        }
        public Struct_8 Read_7()
        {
            return ReadStruct<Struct_8>();
        }
        public Struct_9 Read_8()
        {
            return ReadStruct<Struct_9>();
        }
        public int[] Read_9()
        {
            return ReadFixedPrimitiveArray<int>(3);
        }
        public string Read_10()
        {
            return ReadFixedString(128);
        }
        public string Read_11()
        {
            return ReadFixedString(64);
        }
        public string Read_12()
        {
            return ReadFixedString(131);
        }
        public string Read_13()
        {
            return ReadFixedString(100);
        }
        public string Read_14()
        {
            return ReadFixedString(80);
        }
        public string Read_15()
        {
            return ReadFixedString(260);
        }
        public Struct_9[] Read_16()
        {
            return ReadConformantStructArray<Struct_9>();
        }
        public System.Guid[] Read_17()
        {
            return ReadConformantArrayCallback<System.Guid>(new System.Func<System.Guid>(this.ReadGuid));
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16[] Read_18()
        {
            return ReadConformantArrayCallback<NtApiDotNet.Ndr.Marshal.NdrEnum16>(new System.Func<NtApiDotNet.Ndr.Marshal.NdrEnum16>(this.ReadEnum16));
        }
        public char[] Read_19()
        {
            return ReadConformantArray<char>();
        }
        public string[] Read_20()
        {
            return ReadConformantStringArray(new System.Func<string>(this.ReadConformantVaryingString));
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_9();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int[] Member0;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.Member0 = new int[3];
            return ret;
        }
        public Struct_1(int[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEnum16(Member4);
            m.WriteEnum16(Member8);
            m.WriteGuid(MemberC);
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member1C, "Member1C"));
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member11C, "Member11C"));
            m.WriteInt32(Member19C);
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member1A0, "Member1A0"));
            m.WriteInt32(Member220);
            m.WriteEnum16(Member224);
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member228, "Member228"));
            m.WriteInt32(Member2A8);
            m.WriteEnum16(Member2AC);
            m.WriteEnum16(Member2B0);
            m.WriteInt32(Member2B4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadEnum16();
            Member8 = u.ReadEnum16();
            MemberC = u.ReadGuid();
            Member1C = u.Read_10();
            Member11C = u.Read_11();
            Member19C = u.ReadInt32();
            Member1A0 = u.Read_11();
            Member220 = u.ReadInt32();
            Member224 = u.ReadEnum16();
            Member228 = u.Read_11();
            Member2A8 = u.ReadInt32();
            Member2AC = u.ReadEnum16();
            Member2B0 = u.ReadEnum16();
            Member2B4 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member8;
        public System.Guid MemberC;
        public string Member1C;
        public string Member11C;
        public int Member19C;
        public string Member1A0;
        public int Member220;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member224;
        public string Member228;
        public int Member2A8;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member2AC;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member2B0;
        public int Member2B4;
        public static Struct_2 CreateDefault()
        {
            Struct_2 ret = new Struct_2();
            ret.Member1C = new string('\0', 128);
            ret.Member11C = new string('\0', 64);
            ret.Member1A0 = new string('\0', 64);
            ret.Member228 = new string('\0', 64);
            return ret;
        }
        public Struct_2(int Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member8, System.Guid MemberC, string Member1C, string Member11C, int Member19C, string Member1A0, int Member220, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member224, string Member228, int Member2A8, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member2AC, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member2B0, int Member2B4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member1C = Member1C;
            this.Member11C = Member11C;
            this.Member19C = Member19C;
            this.Member1A0 = Member1A0;
            this.Member220 = Member220;
            this.Member224 = Member224;
            this.Member228 = Member228;
            this.Member2A8 = Member2A8;
            this.Member2AC = Member2AC;
            this.Member2B0 = Member2B0;
            this.Member2B4 = Member2B4;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_12(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_12();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public string Member0;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.Member0 = new string('\0', 131);
            return ret;
        }
        public Struct_3(string Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(int Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Member0);
            m.WriteGuid(Member4);
            m.Write_5(Member14, Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member4 = u.ReadGuid();
            Member14 = u.Read_5();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public System.Guid Member4;
        public Union_6 Member14;
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, System.Guid Member4, Union_6 Member14)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member14 = Member14;
        }
    }
    public struct Union_6 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            throw new System.NotImplementedException();
        }
        void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
        {
            Selector = ((NtApiDotNet.Ndr.Marshal.NdrEnum16)(l));
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Selector);
            if ((Selector == 25))
            {
                m.WriteInt32(Arm_25);
                goto done;
            }
            if ((Selector == 26))
            {
                m.WriteInt32(Arm_26);
                goto done;
            }
            m.WriteInt32(Arm_Default);
        done:
            return;
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Selector = u.ReadEnum16();
            if ((Selector == 25))
            {
                Arm_25 = u.ReadInt32();
                goto done;
            }
            if ((Selector == 26))
            {
                Arm_26 = u.ReadInt32();
                goto done;
            }
            Arm_Default = u.ReadInt32();
        done:
            return;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        private NtApiDotNet.Ndr.Marshal.NdrEnum16 Selector;
        public int Arm_25;
        public int Arm_26;
        public int Arm_Default;
        public static Union_6 CreateDefault()
        {
            return new Union_6();
        }
        public Union_6(NtApiDotNet.Ndr.Marshal.NdrEnum16 Selector, int Arm_25, int Arm_26, int Arm_Default)
        {
            this.Selector = Selector;
            this.Arm_25 = Arm_25;
            this.Arm_26 = Arm_26;
            this.Arm_Default = Arm_Default;
        }
    }
    public struct Struct_7 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_13(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
            m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(MemberC8, "MemberC8"));
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member168, "Member168"));
            m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member268, "Member268"));
            m.Write_15(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member308, "Member308"));
            m.WriteInt32(Member510);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_13();
            MemberC8 = u.Read_14();
            Member168 = u.Read_10();
            Member268 = u.Read_14();
            Member308 = u.Read_15();
            Member510 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public string Member0;
        public string MemberC8;
        public string Member168;
        public string Member268;
        public string Member308;
        public int Member510;
        public static Struct_7 CreateDefault()
        {
            Struct_7 ret = new Struct_7();
            ret.Member0 = new string('\0', 100);
            ret.MemberC8 = new string('\0', 80);
            ret.Member168 = new string('\0', 128);
            ret.Member268 = new string('\0', 80);
            ret.Member308 = new string('\0', 260);
            return ret;
        }
        public Struct_7(string Member0, string MemberC8, string Member168, string Member268, string Member308, int Member510)
        {
            this.Member0 = Member0;
            this.MemberC8 = MemberC8;
            this.Member168 = Member168;
            this.Member268 = Member268;
            this.Member308 = Member308;
            this.Member510 = Member510;
        }
    }
    public struct Struct_8 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<Struct_9[], long>(Member8, new System.Action<Struct_9[], long>(m.Write_16), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<Struct_9[]>(new System.Func<Struct_9[]>(u.Read_16), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_9[]> Member8;
        public static Struct_8 CreateDefault()
        {
            return new Struct_8();
        }
        public Struct_8(int Member0, Struct_9[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_9 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public static Struct_9 CreateDefault()
        {
            return new Struct_9();
        }
        public Struct_9(string Member0, string Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("f26e2372-d601-44f0-84b8-2591d2af2f82", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int PhoneSvcImpl_PhoneRpcCallVoicemail(System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcPublicDial(System.Guid p0, string p1, string p2, System.Nullable<Struct_1> p3, System.Nullable<int> p4, NtApiDotNet.Ndr.Marshal.NdrEnum16 p5, NtApiDotNet.Ndr.Marshal.NdrEnum16 p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p3, new System.Action<Struct_1>(m.Write_0));
            m.WriteReferent(p4, new System.Action<int>(m.WriteInt32));
            m.WriteEnum16(p5);
            m.WriteEnum16(p6);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcCallCapabilityAccessCheck(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetLinePublicInfo(System.Guid p0, out Struct_2 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p1 = u.Read_1();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetLinePublicInfoExtended(System.Guid p0, out Struct_3 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p1 = u.Read_2();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetLinePublicSettings(System.Guid p0, out Struct_4 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            p1 = u.Read_3();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetDefaultOutgoingLine(ref System.Nullable<System.Guid> p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(6, m);
            p0 = u.ReadReferentValue<System.Guid>(new System.Func<System.Guid>(u.ReadGuid), false);
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetCallFilteringEnabled(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(7, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcIsEmergencyNumber(string p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(8, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcIsImmediateDialString(System.Guid p0, string p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(9, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetLines(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, out System.Guid[] p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            _Unmarshal_Helper u = SendReceive(10, m);
            p1 = u.ReadReferent<System.Guid[]>(new System.Func<System.Guid[]>(u.Read_17), false);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcAdvise(NtApiDotNet.Ndr.Marshal.NdrEnum16[] p0, int p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2, out char[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_18(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"), p1);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(11, m);
            p2 = u.ReadContextHandle();
            p3 = u.Read_19();
            return u.ReadInt32();
        }
        public void PhoneSvcImpl_PhoneRpcUnadvise(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(12, m);
            p0 = u.ReadContextHandle();
        }
        public int PhoneSvcImpl_PhoneRpcGetNotifyData(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_5 p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(13, m);
            p1 = u.Read_4();
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcIsPhoneNumberInBlockList(string p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(14, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetActiveSpamFilterApp(out NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, out Struct_3 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(15, m);
            p0 = u.ReadEnum16();
            p1 = u.Read_2();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcSetBlockPrivateNumbersSetting(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(16, m);
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetBlockPrivateNumbersSetting(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(17, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcSetBlockUnknownNumbersSetting(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(18, m);
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetBlockUnknownNumbersSetting(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(19, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcSetFilterAppBlockList(int p0, string[] p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_20(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            _Unmarshal_Helper u = SendReceive(20, m);
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcSetCallOriginInfo(System.Guid p0, Struct_7 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.Write_6(p1);
            _Unmarshal_Helper u = SendReceive(21, m);
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcSetCallerAsActiveAppByType(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            _Unmarshal_Helper u = SendReceive(22, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetActiveAppByType(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, out Struct_3 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            _Unmarshal_Helper u = SendReceive(23, m);
            p1 = u.Read_2();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetDeviceSupportsVideoCalling(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(24, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetDeviceRealTimeTextEnabled(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(25, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetDeviceRealTimeTextAutomaticEnabled(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(26, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetRecordingApplications(out int p0, out int p1, out string p2, int p3, out Struct_8 p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(27, m);
            p0 = u.ReadInt32();
            p1 = u.ReadInt32();
            p2 = u.ReadConformantVaryingString();
            p4 = u.Read_7();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcSetRecordingApplication(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(28, m);
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetVideoCapabilities(string p0, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(29, m);
            p1 = u.ReadEnum16();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcGetShouldMuteKeypad(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(30, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PhoneSvcImpl_PhoneRpcIsVideoCallingEnabled(System.Guid p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(31, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}

