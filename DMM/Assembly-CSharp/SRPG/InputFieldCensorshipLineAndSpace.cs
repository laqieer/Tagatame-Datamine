// Decompiled with JetBrains decompiler
// Type: SRPG.InputFieldCensorshipLineAndSpace
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FC4")]
  public class InputFieldCensorshipLineAndSpace : InputFieldCensorship
  {
    [Token(Token = "0x40037AE")]
    [FieldOffset(Offset = "0x188")]
    public Text RemainTextObj;
    [Token(Token = "0x40037AF")]
    [FieldOffset(Offset = "0x18C")]
    private bool mIsNewLineAdd;

    [Token(Token = "0x600419D")]
    [Address(RVA = "0x1195AA0", Offset = "0x11948A0", VA = "0x11195AA0", Slot = "83")]
    protected override char MyValidate(string input, int charIndex, char addedChar) => new char();

    [Token(Token = "0x600419E")]
    [Address(RVA = "0x1195740", Offset = "0x1194540", VA = "0x11195740")]
    public string GetDrawLastCharacter() => (string) null;

    [Token(Token = "0x600419F")]
    [Address(RVA = "0x1195840", Offset = "0x1194640", VA = "0x11195840")]
    public void InputCharNum(string _text)
    {
    }

    [Token(Token = "0x60041A0")]
    [Address(RVA = "0x1195BE0", Offset = "0x11949E0", VA = "0x11195BE0")]
    public InputFieldCensorshipLineAndSpace()
    {
    }
  }
}
