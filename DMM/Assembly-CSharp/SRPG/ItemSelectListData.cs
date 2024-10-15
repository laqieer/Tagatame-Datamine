// Decompiled with JetBrains decompiler
// Type: SRPG.ItemSelectListData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001537")]
  public class ItemSelectListData
  {
    [Token(Token = "0x4004D95")]
    [FieldOffset(Offset = "0x8")]
    public List<ItemSelectListItemData> items;

    [Token(Token = "0x60057CD")]
    [Address(RVA = "0x12DB9A0", Offset = "0x12DA7A0", VA = "0x112DB9A0")]
    public void Deserialize(Json_ItemSelectResponse json)
    {
    }

    [Token(Token = "0x60057CE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ItemSelectListData()
    {
    }
  }
}
