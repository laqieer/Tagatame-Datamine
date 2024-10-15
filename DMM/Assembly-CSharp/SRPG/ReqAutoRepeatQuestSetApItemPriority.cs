// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAutoRepeatQuestSetApItemPriority
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
  [Token(Token = "0x2003250")]
  public class ReqAutoRepeatQuestSetApItemPriority : WebAPI
  {
    [Token(Token = "0x600DEF1")]
    [Address(RVA = "0xA93770", Offset = "0xA92570", VA = "0x10A93770")]
    public ReqAutoRepeatQuestSetApItemPriority(
      string[] ap_items,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003251")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE8B")]
      [FieldOffset(Offset = "0x8")]
      public string[] drip_priority;

      [Token(Token = "0x600DEF2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003252")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE8C")]
      [FieldOffset(Offset = "0x8")]
      public string[] drip_priority;

      [Token(Token = "0x600DEF3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
