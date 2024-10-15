// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAutoRepeatQuestProgress
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
  [Token(Token = "0x2003242")]
  public class ReqAutoRepeatQuestProgress : WebAPI
  {
    [Token(Token = "0x600DEE0")]
    [Address(RVA = "0xA93690", Offset = "0xA92490", VA = "0x10A93690")]
    public ReqAutoRepeatQuestProgress(
      int current_lap,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003243")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE60")]
      [FieldOffset(Offset = "0x8")]
      public int current_lap_num;

      [Token(Token = "0x600DEE1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003244")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE61")]
      [FieldOffset(Offset = "0x8")]
      public Json_AutoRepeatQuestData auto_repeat;
      [Token(Token = "0x400EE62")]
      [FieldOffset(Offset = "0xC")]
      public int box_extension_count;
      [Token(Token = "0x400EE63")]
      [FieldOffset(Offset = "0x10")]
      public int box_expansion_purchase_count;

      [Token(Token = "0x600DEE2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
