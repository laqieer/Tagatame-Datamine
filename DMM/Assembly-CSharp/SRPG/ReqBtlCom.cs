// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlCom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030A2")]
  public class ReqBtlCom : WebAPI
  {
    [Token(Token = "0x600DD22")]
    [Address(RVA = "0xA83A40", Offset = "0xA82840", VA = "0x10A83A40")]
    public ReqBtlCom(
      Network.ResponseCallback response,
      bool refresh = false,
      bool tower_progress = false,
      bool is_genesis = false,
      bool is_advance = false,
      bool is_combat_power = false,
      bool is_dragongod = false)
    {
    }

    [Token(Token = "0x20030A3")]
    [Serializable]
    public class GenesisStar
    {
      [Token(Token = "0x400EC19")]
      [FieldOffset(Offset = "0x8")]
      public string area_id;
      [Token(Token = "0x400EC1A")]
      [FieldOffset(Offset = "0xC")]
      public ReqBtlCom.GenesisStar.Mode[] mode;

      [Token(Token = "0x600DD23")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public GenesisStar()
      {
      }

      [Token(Token = "0x20030A4")]
      [Serializable]
      public class Mode
      {
        [Token(Token = "0x400EC1B")]
        [FieldOffset(Offset = "0x8")]
        public int[] is_reward;

        [Token(Token = "0x600DD24")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Mode()
        {
        }
      }
    }

    [Token(Token = "0x20030A5")]
    [Serializable]
    public class AdvanceStar
    {
      [Token(Token = "0x400EC1C")]
      [FieldOffset(Offset = "0x8")]
      public string area_id;
      [Token(Token = "0x400EC1D")]
      [FieldOffset(Offset = "0xC")]
      public ReqBtlCom.AdvanceStar.Mode[] mode;

      [Token(Token = "0x600DD25")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public AdvanceStar()
      {
      }

      [Token(Token = "0x20030A6")]
      [Serializable]
      public class Mode
      {
        [Token(Token = "0x400EC1E")]
        [FieldOffset(Offset = "0x8")]
        public int[] is_reward;

        [Token(Token = "0x600DD26")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Mode()
        {
        }
      }
    }
  }
}
