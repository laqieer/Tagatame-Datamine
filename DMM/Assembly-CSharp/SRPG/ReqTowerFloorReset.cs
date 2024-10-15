// Decompiled with JetBrains decompiler
// Type: SRPG.ReqTowerFloorReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031AE")]
  public class ReqTowerFloorReset : WebAPI
  {
    [Token(Token = "0x600DE48")]
    [Address(RVA = "0xA9E920", Offset = "0xA9D720", VA = "0x10A9E920")]
    public ReqTowerFloorReset(
      string tower_iname,
      string floor_iname,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031AF")]
    public class JSON_CoinParam
    {
      [Token(Token = "0x400ED65")]
      [FieldOffset(Offset = "0x8")]
      public int free;
      [Token(Token = "0x400ED66")]
      [FieldOffset(Offset = "0xC")]
      public int paid;
      [Token(Token = "0x400ED67")]
      [FieldOffset(Offset = "0x10")]
      public int com;

      [Token(Token = "0x600DE49")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_CoinParam()
      {
      }
    }

    [Token(Token = "0x20031B0")]
    [Serializable]
    public class Json_Response
    {
      [Token(Token = "0x400ED68")]
      [FieldOffset(Offset = "0x8")]
      public ReqTowerFloorReset.JSON_CoinParam coin;

      [Token(Token = "0x600DE4A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_Response()
      {
      }
    }
  }
}
