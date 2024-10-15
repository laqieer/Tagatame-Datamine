// Decompiled with JetBrains decompiler
// Type: SRPG.NewBadgeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027BB")]
  public class NewBadgeParam
  {
    [Token(Token = "0x400BC1D")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsUseNewFlag;
    [Token(Token = "0x400BC1E")]
    [FieldOffset(Offset = "0x9")]
    private bool mIsNew;
    [Token(Token = "0x400BC1F")]
    [FieldOffset(Offset = "0xA")]
    private NewBadgeType mType;

    [Token(Token = "0x17001893")]
    public bool use_newflag
    {
      [Token(Token = "0x600B273"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001894")]
    public bool is_new
    {
      [Token(Token = "0x600B274"), Address(RVA = "0x34B080", Offset = "0x349E80", VA = "0x1034B080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001895")]
    public NewBadgeType type
    {
      [Token(Token = "0x600B275"), Address(RVA = "0x34B070", Offset = "0x349E70", VA = "0x1034B070")] get
      {
        return new NewBadgeType();
      }
    }

    [Token(Token = "0x600B276")]
    [Address(RVA = "0x7A7D40", Offset = "0x7A6B40", VA = "0x107A7D40")]
    public NewBadgeParam(bool use, bool isnew, NewBadgeType type)
    {
    }
  }
}
