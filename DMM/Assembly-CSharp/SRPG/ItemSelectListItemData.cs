// Decompiled with JetBrains decompiler
// Type: SRPG.ItemSelectListItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001536")]
  public class ItemSelectListItemData
  {
    [Token(Token = "0x4004D91")]
    [FieldOffset(Offset = "0x8")]
    public string iiname;
    [Token(Token = "0x4004D92")]
    [FieldOffset(Offset = "0xC")]
    public short id;
    [Token(Token = "0x4004D93")]
    [FieldOffset(Offset = "0xE")]
    public short num;
    [Token(Token = "0x4004D94")]
    [FieldOffset(Offset = "0x10")]
    public ItemParam param;

    [Token(Token = "0x60057CB")]
    [Address(RVA = "0x12DBBB0", Offset = "0x12DA9B0", VA = "0x112DBBB0")]
    public void Deserialize(Json_ItemSelectItem json)
    {
    }

    [Token(Token = "0x60057CC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ItemSelectListItemData()
    {
    }
  }
}
