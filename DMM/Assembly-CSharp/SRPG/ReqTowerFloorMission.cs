// Decompiled with JetBrains decompiler
// Type: SRPG.ReqTowerFloorMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031B1")]
  public class ReqTowerFloorMission : WebAPI
  {
    [Token(Token = "0x600DE4B")]
    [Address(RVA = "0xA9E6E0", Offset = "0xA9D4E0", VA = "0x10A9E6E0")]
    public ReqTowerFloorMission(
      string tower_iname,
      string floor_iname,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031B2")]
    [Serializable]
    public class Json_Response
    {
      [Token(Token = "0x400ED69")]
      [FieldOffset(Offset = "0x8")]
      public int[] missions;
      [Token(Token = "0x400ED6A")]
      [FieldOffset(Offset = "0xC")]
      public int[] missions_val;

      [Token(Token = "0x600DE4C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_Response()
      {
      }
    }
  }
}
