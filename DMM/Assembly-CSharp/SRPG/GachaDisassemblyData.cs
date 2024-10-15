// Decompiled with JetBrains decompiler
// Type: SRPG.GachaDisassemblyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F1B")]
  public class GachaDisassemblyData
  {
    [Token(Token = "0x4002EF7")]
    [FieldOffset(Offset = "0x8")]
    private int m_gold;
    [Token(Token = "0x4002EF8")]
    [FieldOffset(Offset = "0xC")]
    private ItemData[] m_items;

    [Token(Token = "0x17000541")]
    public int gold
    {
      [Token(Token = "0x6003F0C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000542")]
    public ItemData[] items
    {
      [Token(Token = "0x6003F0D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ItemData[]) null;
      }
    }

    [Token(Token = "0x17000543")]
    public bool IsExists
    {
      [Token(Token = "0x6003F0E"), Address(RVA = "0x11749E0", Offset = "0x11737E0", VA = "0x111749E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003F0F")]
    [Address(RVA = "0x11748D0", Offset = "0x11736D0", VA = "0x111748D0")]
    public void Deserialize(Json_DropDisassembly json)
    {
    }

    [Token(Token = "0x6003F10")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GachaDisassemblyData()
    {
    }
  }
}
