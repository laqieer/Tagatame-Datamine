// Decompiled with JetBrains decompiler
// Type: SRPG.GachaPickupSelectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AF7")]
  public class GachaPickupSelectParam
  {
    [Token(Token = "0x40066A7")]
    [FieldOffset(Offset = "0x8")]
    private int mSelectPickupNum;
    [Token(Token = "0x40066A8")]
    [FieldOffset(Offset = "0xC")]
    private List<GachaDropData> mPickupSelectList;

    [Token(Token = "0x17000CD2")]
    public int select_pickup_num
    {
      [Token(Token = "0x6006F48"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CD3")]
    public List<GachaDropData> pickup_select_list
    {
      [Token(Token = "0x6006F49"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GachaDropData>) null;
      }
    }

    [Token(Token = "0x6006F4A")]
    [Address(RVA = "0x369E60", Offset = "0x368C60", VA = "0x10369E60")]
    public GachaPickupSelectParam()
    {
    }

    [Token(Token = "0x6006F4B")]
    [Address(RVA = "0x369D60", Offset = "0x368B60", VA = "0x10369D60")]
    public void Setup(int num, Json_GachaPickups[] jsons)
    {
    }
  }
}
