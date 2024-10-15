// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAutoRepeatQuestBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200324C")]
  public class ReqAutoRepeatQuestBox : WebAPI
  {
    [Token(Token = "0x600DEEA")]
    [Address(RVA = "0xA93540", Offset = "0xA92340", VA = "0x10A93540")]
    public ReqAutoRepeatQuestBox(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200324D")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE80")]
      [FieldOffset(Offset = "0x8")]
      public int box_extension_count;
      [Token(Token = "0x400EE81")]
      [FieldOffset(Offset = "0xC")]
      public string[] drip_priority;
      [Token(Token = "0x400EE82")]
      [FieldOffset(Offset = "0x10")]
      public int box_expansion_purchase_count;
      [Token(Token = "0x400EE83")]
      [FieldOffset(Offset = "0x14")]
      public int is_full_box;
      [Token(Token = "0x400EE84")]
      [FieldOffset(Offset = "0x18")]
      public int is_use_drip;
      [Token(Token = "0x400EE85")]
      [FieldOffset(Offset = "0x1C")]
      public int is_push;

      [Token(Token = "0x17001D07")]
      public bool IsFullBox
      {
        [Token(Token = "0x600DEEB"), Address(RVA = "0x3683C0", Offset = "0x3671C0", VA = "0x103683C0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001D08")]
      public bool IsUseDrip
      {
        [Token(Token = "0x600DEEC"), Address(RVA = "0x3B3010", Offset = "0x3B1E10", VA = "0x103B3010")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001D09")]
      public bool IsPush
      {
        [Token(Token = "0x600DEED"), Address(RVA = "0x568220", Offset = "0x567020", VA = "0x10568220")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600DEEE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
