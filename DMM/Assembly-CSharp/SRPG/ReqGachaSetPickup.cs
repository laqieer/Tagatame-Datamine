// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGachaSetPickup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200320F")]
  public class ReqGachaSetPickup : WebAPI
  {
    [Token(Token = "0x600DEAB")]
    [Address(RVA = "0xA97460", Offset = "0xA96260", VA = "0x10A97460")]
    public ReqGachaSetPickup(
      ReqGachaSetPickup.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003210")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDFD")]
      [FieldOffset(Offset = "0x8")]
      public string gachaid;
      [Token(Token = "0x400EDFE")]
      [FieldOffset(Offset = "0xC")]
      public ReqGachaSetPickup.PickupData[] pickups;

      [Token(Token = "0x600DEAC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003211")]
    [Serializable]
    public class PickupData
    {
      [Token(Token = "0x400EDFF")]
      [FieldOffset(Offset = "0x8")]
      public string itype;
      [Token(Token = "0x400EE00")]
      [FieldOffset(Offset = "0xC")]
      public string iname;

      [Token(Token = "0x600DEAD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public PickupData()
      {
      }
    }
  }
}
