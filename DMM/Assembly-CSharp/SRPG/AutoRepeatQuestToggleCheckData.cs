// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestToggleCheckData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200199B")]
  public class AutoRepeatQuestToggleCheckData
  {
    [Token(Token = "0x4005DD5")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsInitialized;
    [Token(Token = "0x4005DD6")]
    [FieldOffset(Offset = "0x9")]
    private bool mAutoRepeatQuestToggleFullBox;
    [Token(Token = "0x4005DD7")]
    [FieldOffset(Offset = "0xA")]
    private bool mAutoRepeatQuestToggleDrip;
    [Token(Token = "0x4005DD8")]
    [FieldOffset(Offset = "0xB")]
    private bool mAutoRepeatQuestTogglePush;

    [Token(Token = "0x17000AF1")]
    public bool IsInitialized
    {
      [Token(Token = "0x6006873"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000AF2")]
    public bool AutoRepeatQuestToggleFullBox
    {
      [Token(Token = "0x6006874"), Address(RVA = "0x34B080", Offset = "0x349E80", VA = "0x1034B080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000AF3")]
    public bool AutoRepeatQuestToggleDrip
    {
      [Token(Token = "0x6006875"), Address(RVA = "0x34B070", Offset = "0x349E70", VA = "0x1034B070")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000AF4")]
    public bool AutoRepeatQuestTogglePush
    {
      [Token(Token = "0x6006876"), Address(RVA = "0x34B090", Offset = "0x349E90", VA = "0x1034B090")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6006877")]
    [Address(RVA = "0x34B050", Offset = "0x349E50", VA = "0x1034B050")]
    public void Setup(bool is_full_box, bool is_drip, bool is_push)
    {
    }

    [Token(Token = "0x6006878")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AutoRepeatQuestToggleCheckData()
    {
    }
  }
}
