// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestBoxData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200199A")]
  public class AutoRepeatQuestBoxData
  {
    [Token(Token = "0x4005DD2")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsInitialized;
    [Token(Token = "0x4005DD3")]
    [FieldOffset(Offset = "0xC")]
    private int mAddCount;
    [Token(Token = "0x4005DD4")]
    [FieldOffset(Offset = "0x10")]
    private int mExpansionAddCount;

    [Token(Token = "0x17000AED")]
    public bool IsInitialized
    {
      [Token(Token = "0x600686B"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000AEE")]
    public int AddCount
    {
      [Token(Token = "0x600686C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AEF")]
    public int ExpansionAddCount
    {
      [Token(Token = "0x600686D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AF0")]
    public int Size
    {
      [Token(Token = "0x600686E"), Address(RVA = "0x349BA0", Offset = "0x3489A0", VA = "0x10349BA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600686F")]
    [Address(RVA = "0x349B80", Offset = "0x348980", VA = "0x10349B80")]
    public void Setup(int box_add_count)
    {
    }

    [Token(Token = "0x6006870")]
    [Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")]
    public void SetupExpansion(int box_add_count)
    {
    }

    [Token(Token = "0x6006871")]
    [Address(RVA = "0x349B70", Offset = "0x348970", VA = "0x10349B70")]
    public void SetNextReqAPI()
    {
    }

    [Token(Token = "0x6006872")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AutoRepeatQuestBoxData()
    {
    }
  }
}
