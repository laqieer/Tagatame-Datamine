// Decompiled with JetBrains decompiler
// Type: SRPG.Models.PointQuestChapterSelectorItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003375")]
  public class PointQuestChapterSelectorItemModel
  {
    [Token(Token = "0x400F32A")]
    [FieldOffset(Offset = "0x8")]
    private string mTitleText;
    [Token(Token = "0x400F32B")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsLock;
    [Token(Token = "0x400F32C")]
    [FieldOffset(Offset = "0xD")]
    private bool mIsDispMessageBox;
    [Token(Token = "0x400F32D")]
    [FieldOffset(Offset = "0x10")]
    private string mMessageBoxText;
    [Token(Token = "0x400F32E")]
    [FieldOffset(Offset = "0x14")]
    private string mSpritePath;

    [Token(Token = "0x17001F4E")]
    public string TitleText
    {
      [Token(Token = "0x600E47A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F4F")]
    public bool IsLock
    {
      [Token(Token = "0x600E47B"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F50")]
    public bool IsDispMessageBox
    {
      [Token(Token = "0x600E47C"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F51")]
    public string MessageBoxText
    {
      [Token(Token = "0x600E47D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F52")]
    public string SpritePath
    {
      [Token(Token = "0x600E47E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E47F")]
    [Address(RVA = "0xABBA60", Offset = "0xABA860", VA = "0x10ABBA60")]
    public void Initialize(ChapterParam _param, bool _is_out_of_period, bool _is_liberation)
    {
    }

    [Token(Token = "0x600E480")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestChapterSelectorItemModel()
    {
    }
  }
}
