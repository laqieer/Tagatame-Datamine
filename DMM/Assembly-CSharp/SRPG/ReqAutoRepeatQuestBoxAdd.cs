// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAutoRepeatQuestBoxAdd
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
  [Token(Token = "0x200324E")]
  public class ReqAutoRepeatQuestBoxAdd : WebAPI
  {
    [Token(Token = "0x600DEEF")]
    [Address(RVA = "0xA93490", Offset = "0xA92290", VA = "0x10A93490")]
    public ReqAutoRepeatQuestBoxAdd(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200324F")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE86")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EE87")]
      [FieldOffset(Offset = "0xC")]
      public int box_extension_count;
      [Token(Token = "0x400EE88")]
      [FieldOffset(Offset = "0x10")]
      public int lap_num;
      [Token(Token = "0x400EE89")]
      [FieldOffset(Offset = "0x14")]
      public int is_push;
      [Token(Token = "0x400EE8A")]
      [FieldOffset(Offset = "0x18")]
      public int box_expansion_purchase_count;

      [Token(Token = "0x600DEF0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
