// Decompiled with JetBrains decompiler
// Type: SRPG.ReqWorldRaidResetBattlePoint
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
  [Token(Token = "0x2003077")]
  public class ReqWorldRaidResetBattlePoint : WebAPI
  {
    [Token(Token = "0x600DCE0")]
    [Address(RVA = "0xA7D9C0", Offset = "0xA7C7C0", VA = "0x10A7D9C0")]
    public ReqWorldRaidResetBattlePoint(
      int _num,
      int _current_num,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003078")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBF8")]
      [FieldOffset(Offset = "0x8")]
      public int add_num;
      [Token(Token = "0x400EBF9")]
      [FieldOffset(Offset = "0xC")]
      public int current_num;

      [Token(Token = "0x600DCE1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003079")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EBFA")]
      [FieldOffset(Offset = "0x8")]
      public JSON_WorldRaidBattlePoint bp;
      [Token(Token = "0x400EBFB")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;

      [Token(Token = "0x600DCE2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
