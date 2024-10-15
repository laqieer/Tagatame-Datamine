// Decompiled with JetBrains decompiler
// Type: FlowNode_OpenURL
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001FC")]
[FlowNode.NodeType("Common/OpenURL", 58751)]
[FlowNode.Pin(1, "Input", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(2, "Output", FlowNode.PinTypes.Output, 2)]
[AddComponentMenu("")]
public class FlowNode_OpenURL : FlowNode
{
  [Token(Token = "0x40008B3")]
  public const string OPENURL_VALUELIST_KEY_URL = "OPENURL_VALUELIST_KEY_URL";
  [Token(Token = "0x40008B4")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  [HideInInspector]
  private string URL;
  [Token(Token = "0x40008B5")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private FlowNode_OpenURL.URL_Mode URLMode;
  [Token(Token = "0x40008B6")]
  [FieldOffset(Offset = "0x20")]
  [HideInInspector]
  [SerializeField]
  private bool UseVariableURL;
  [Token(Token = "0x40008B7")]
  [FieldOffset(Offset = "0x21")]
  [HideInInspector]
  [SerializeField]
  private bool ResetVariableValue;
  [Token(Token = "0x40008B8")]
  [FieldOffset(Offset = "0x24")]
  [SerializeField]
  [HideInInspector]
  private string VariableName;
  [Token(Token = "0x40008B9")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private SerializeValueBehaviour ValueList;

  [Token(Token = "0x6000B38")]
  [Address(RVA = "0x107C890", Offset = "0x107B690", VA = "0x1107C890", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B39")]
  [Address(RVA = "0x107C7C0", Offset = "0x107B5C0", VA = "0x1107C7C0")]
  private string BaseURL(FlowNode_OpenURL.URL_Mode urlMode) => (string) null;

  [Token(Token = "0x6000B3A")]
  [Address(RVA = "0x107C8B0", Offset = "0x107B6B0", VA = "0x1107C8B0")]
  private void Open()
  {
  }

  [Token(Token = "0x6000B3B")]
  [Address(RVA = "0x107CB60", Offset = "0x107B960", VA = "0x1107CB60")]
  public FlowNode_OpenURL()
  {
  }

  [Token(Token = "0x20001FD")]
  public enum URL_Mode
  {
    [Token(Token = "0x40008BB")] APIHost,
    [Token(Token = "0x40008BC")] DLHost,
    [Token(Token = "0x40008BD")] SiteHost,
    [Token(Token = "0x40008BE")] NewsHost,
    [Token(Token = "0x40008BF")] Direct,
  }
}
