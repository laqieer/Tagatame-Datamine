// Decompiled with JetBrains decompiler
// Type: SRPG.ReqWorldRaidBoss
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
  [Token(Token = "0x2003063")]
  public class ReqWorldRaidBoss : WebAPI
  {
    [Token(Token = "0x600DCCB")]
    [Address(RVA = "0xA7CD80", Offset = "0xA7BB80", VA = "0x10A7CD80")]
    public ReqWorldRaidBoss(
      string worldRaidIname,
      string bossIname,
      int _lap,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003064")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBD3")]
      [FieldOffset(Offset = "0x8")]
      public string worldraid_iname;
      [Token(Token = "0x400EBD4")]
      [FieldOffset(Offset = "0xC")]
      public string boss_iname;
      [Token(Token = "0x400EBD5")]
      [FieldOffset(Offset = "0x10")]
      public int lap;

      [Token(Token = "0x600DCCC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003065")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EBD6")]
      [FieldOffset(Offset = "0x8")]
      public JSON_WorldRaidBossDetailData boss;

      [Token(Token = "0x600DCCD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
