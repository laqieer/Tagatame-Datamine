// Decompiled with JetBrains decompiler
// Type: SRPG.UnitSelectListItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015D8")]
  public class UnitSelectListItemData
  {
    [Token(Token = "0x4004F5F")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4004F60")]
    [FieldOffset(Offset = "0xC")]
    public UnitParam param;
    [Token(Token = "0x4004F61")]
    [FieldOffset(Offset = "0x10")]
    public int convert_piece_num;

    [Token(Token = "0x60059C9")]
    [Address(RVA = "0x12F2470", Offset = "0x12F1270", VA = "0x112F2470")]
    public void Deserialize(Json_UnitSelectItem json)
    {
    }

    [Token(Token = "0x60059CA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitSelectListItemData()
    {
    }
  }
}
