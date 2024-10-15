// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingPage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200253F")]
  public class GuildTrainingPage
  {
    [Token(Token = "0x400AABA")]
    [FieldOffset(Offset = "0x8")]
    private string mExpansionID;
    [Token(Token = "0x400AABB")]
    [FieldOffset(Offset = "0xC")]
    private int mPage;
    [Token(Token = "0x400AABC")]
    [FieldOffset(Offset = "0x10")]
    private int mHeadSlot;
    [Token(Token = "0x400AABD")]
    [FieldOffset(Offset = "0x14")]
    private int mTailSlot;

    [Token(Token = "0x170016ED")]
    public string ExpansionID
    {
      [Token(Token = "0x600A43B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170016EE")]
    public int Page
    {
      [Token(Token = "0x600A43C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170016EF")]
    public int HeadSlot
    {
      [Token(Token = "0x600A43D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170016F0")]
    public int TailSlot
    {
      [Token(Token = "0x600A43E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A43F")]
    [Address(RVA = "0x661F30", Offset = "0x660D30", VA = "0x10661F30")]
    public GuildTrainingPage(string expansionID, int pageNum, int slotNum, int rangeNum)
    {
    }

    [Token(Token = "0x600A440")]
    [Address(RVA = "0x661F10", Offset = "0x660D10", VA = "0x10661F10")]
    private void SetSlotRange(int slotNum, int rangeNum)
    {
    }
  }
}
