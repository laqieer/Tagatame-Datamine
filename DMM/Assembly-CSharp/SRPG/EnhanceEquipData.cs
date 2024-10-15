// Decompiled with JetBrains decompiler
// Type: SRPG.EnhanceEquipData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200234F")]
  public class EnhanceEquipData
  {
    [Token(Token = "0x4009E3D")]
    [FieldOffset(Offset = "0x8")]
    public EquipData equip;
    [Token(Token = "0x4009E3E")]
    [FieldOffset(Offset = "0xC")]
    public int gainexp;
    [Token(Token = "0x4009E3F")]
    [FieldOffset(Offset = "0x10")]
    public bool is_enhanced;

    [Token(Token = "0x600983E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EnhanceEquipData()
    {
    }
  }
}
