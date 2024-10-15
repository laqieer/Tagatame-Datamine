// Decompiled with JetBrains decompiler
// Type: SRPG.NeedEquipItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200104B")]
  public class NeedEquipItem
  {
    [Token(Token = "0x4003A22")]
    [FieldOffset(Offset = "0x8")]
    private ItemParam param;
    [Token(Token = "0x4003A23")]
    [FieldOffset(Offset = "0xC")]
    private int need_picec_num;

    [Token(Token = "0x60042DA")]
    [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
    public NeedEquipItem(ItemParam item_param, int need_picec)
    {
    }

    [Token(Token = "0x17000626")]
    public string Iname
    {
      [Token(Token = "0x60042DB"), Address(RVA = "0x805480", Offset = "0x804280", VA = "0x10805480")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000627")]
    public int CommonType
    {
      [Token(Token = "0x60042DC"), Address(RVA = "0x11DFB00", Offset = "0x11DE900", VA = "0x111DFB00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000628")]
    public int NeedPiece
    {
      [Token(Token = "0x60042DD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000629")]
    public ItemParam Param
    {
      [Token(Token = "0x60042DE"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x60042DF")]
    [Address(RVA = "0x87CE10", Offset = "0x87BC10", VA = "0x1087CE10")]
    public void AddPicec(int need_picec)
    {
    }

    [Token(Token = "0x60042E0")]
    [Address(RVA = "0x87CE20", Offset = "0x87BC20", VA = "0x1087CE20")]
    public void SubPicec(int need_picec)
    {
    }
  }
}
