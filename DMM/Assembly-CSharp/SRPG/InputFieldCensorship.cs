// Decompiled with JetBrains decompiler
// Type: SRPG.InputFieldCensorship
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FC2")]
  public class InputFieldCensorship : SRPG_InputField
  {
    [Token(Token = "0x40037AA")]
    [FieldOffset(Offset = "0x180")]
    public bool CheckCharacterLimitAtEnded;
    [Token(Token = "0x40037AB")]
    [FieldOffset(Offset = "0x184")]
    public int CheckCharacterLimitAtEndedCount;

    [Token(Token = "0x170005DA")]
    public new string text
    {
      [Token(Token = "0x6004196"), Address(RVA = "0x349390", Offset = "0x348190", VA = "0x10349390")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6004197"), Address(RVA = "0x1195E20", Offset = "0x1194C20", VA = "0x11195E20")] set
      {
      }
    }

    [Token(Token = "0x6004198")]
    [Address(RVA = "0x1195D30", Offset = "0x1194B30", VA = "0x11195D30", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x6004199")]
    [Address(RVA = "0x1195CA0", Offset = "0x1194AA0", VA = "0x11195CA0", Slot = "83")]
    protected virtual char MyValidate(string input, int charIndex, char addedChar) => new char();

    [Token(Token = "0x600419A")]
    [Address(RVA = "0x1195C30", Offset = "0x1194A30", VA = "0x11195C30", Slot = "84")]
    public virtual void EndEdit(string text)
    {
    }

    [Token(Token = "0x600419B")]
    [Address(RVA = "0x1195BE0", Offset = "0x11949E0", VA = "0x11195BE0")]
    public InputFieldCensorship()
    {
    }

    [Token(Token = "0x2000FC3")]
    [Serializable]
    public class ValidCodeSegment
    {
      [Token(Token = "0x40037AC")]
      [FieldOffset(Offset = "0x8")]
      public int Start;
      [Token(Token = "0x40037AD")]
      [FieldOffset(Offset = "0xC")]
      public int End;

      [Token(Token = "0x600419C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ValidCodeSegment()
      {
      }
    }
  }
}
