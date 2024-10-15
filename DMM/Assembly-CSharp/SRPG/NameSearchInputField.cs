// Decompiled with JetBrains decompiler
// Type: SRPG.NameSearchInputField
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027B3")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "入力完了", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(111, "入力完了", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(121, "更新処理", FlowNode.PinTypes.Output, 121)]
  public class NameSearchInputField : InputFieldCensorship, IFlowInterface
  {
    [Token(Token = "0x400BBF5")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400BBF6")]
    private const int PIN_IN_INPUT_END = 11;
    [Token(Token = "0x400BBF7")]
    private const int PIN_OUT_INPUT_END = 111;
    [Token(Token = "0x400BBF8")]
    private const int PIN_OUT_REFRESH = 121;

    [Token(Token = "0x600B24F")]
    [Address(RVA = "0x7A67B0", Offset = "0x7A55B0", VA = "0x107A67B0", Slot = "85")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B250")]
    [Address(RVA = "0x7A6810", Offset = "0x7A5610", VA = "0x107A6810", Slot = "83")]
    protected override char MyValidate(string input, int charIndex, char addedChar) => new char();

    [Token(Token = "0x600B251")]
    [Address(RVA = "0x7A67E0", Offset = "0x7A55E0", VA = "0x107A67E0", Slot = "84")]
    public override void EndEdit(string text)
    {
    }

    [Token(Token = "0x600B252")]
    [Address(RVA = "0x7A6910", Offset = "0x7A5710", VA = "0x107A6910")]
    public NameSearchInputField()
    {
    }
  }
}
