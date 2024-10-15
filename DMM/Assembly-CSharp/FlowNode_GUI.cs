// Decompiled with JetBrains decompiler
// Type: FlowNode_GUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001DB")]
[FlowNode.Pin(2, "Destroyed", FlowNode.PinTypes.Output, 11)]
[AddComponentMenu("")]
[FlowNode.NodeType("Common/GUI", 32741)]
[FlowNode.Pin(100, "Create", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(101, "Destroy", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(1, "Created", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(102, "Preload", FlowNode.PinTypes.Input, 2)]
public class FlowNode_GUI : FlowNode_ExternalLink
{
  [Token(Token = "0x4000859")]
  [FieldOffset(Offset = "0x30")]
  [StringIsResourcePath(typeof (GameObject))]
  public string ResourcePath;
  [Token(Token = "0x400085A")]
  [FieldOffset(Offset = "0x34")]
  public bool Modal;
  [Token(Token = "0x400085B")]
  [FieldOffset(Offset = "0x35")]
  public bool SystemModal;
  [Token(Token = "0x400085C")]
  [FieldOffset(Offset = "0x38")]
  private LoadRequest mResourceRequest;
  [Token(Token = "0x400085D")]
  [FieldOffset(Offset = "0x3C")]
  public bool OverridePriority;
  [Token(Token = "0x400085E")]
  [FieldOffset(Offset = "0x40")]
  public int Priority;
  [Token(Token = "0x400085F")]
  [FieldOffset(Offset = "0x44")]
  public bool LoadImmediately;
  [Token(Token = "0x4000860")]
  [FieldOffset(Offset = "0x48")]
  public GameObject InstanceRef;
  [Token(Token = "0x4000861")]
  [FieldOffset(Offset = "0x4C")]
  public SerializeValueBehaviour ValueList;
  [Token(Token = "0x4000862")]
  [FieldOffset(Offset = "0x50")]
  protected DestroyEventListener mListener;

  [Token(Token = "0x17000158")]
  protected override bool ShouldCreateInstanceOnStart
  {
    [Token(Token = "0x6000AB8"), Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "13")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000AB9")]
  [Address(RVA = "0xF4C3B0", Offset = "0xF4B1B0", VA = "0x10F4C3B0", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000ABA")]
  [Address(RVA = "0xF4D200", Offset = "0xF4C000", VA = "0x10F4D200", Slot = "14")]
  protected override void Start()
  {
  }

  [Token(Token = "0x6000ABB")]
  [Address(RVA = "0xF4C440", Offset = "0xF4B240", VA = "0x10F4C440")]
  private void LoadResource()
  {
  }

  [Token(Token = "0x6000ABC")]
  [Address(RVA = "0xF4C6E0", Offset = "0xF4B4E0", VA = "0x10F4C6E0", Slot = "17")]
  protected virtual void OnCreatePinActive()
  {
  }

  [Token(Token = "0x6000ABD")]
  [Address(RVA = "0xF4A700", Offset = "0xF49500", VA = "0x10F4A700", Slot = "5")]
  public override void OnActivate(int pinID, SerializeValueList _list)
  {
  }

  [Token(Token = "0x6000ABE")]
  [Address(RVA = "0xF4C500", Offset = "0xF4B300", VA = "0x10F4C500", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000ABF")]
  [Address(RVA = "0xF4CF80", Offset = "0xF4BD80", VA = "0x10F4CF80")]
  protected void OnInstanceDestroyTrigger(GameObject go)
  {
  }

  [Token(Token = "0x6000AC0")]
  [Address(RVA = "0xF4C8B0", Offset = "0xF4B6B0", VA = "0x10F4C8B0", Slot = "8")]
  protected override void OnDestroy()
  {
  }

  [Token(Token = "0x6000AC1")]
  [Address(RVA = "0xF4D000", Offset = "0xF4BE00", VA = "0x10F4D000", Slot = "16")]
  protected override void OnInstanceDestroy()
  {
  }

  [Token(Token = "0x6000AC2")]
  [Address(RVA = "0xF4B6F0", Offset = "0xF4A4F0", VA = "0x10F4B6F0")]
  private void OnApplicationQuit()
  {
  }

  [Token(Token = "0x6000AC3")]
  [Address(RVA = "0xF4D270", Offset = "0xF4C070", VA = "0x10F4D270")]
  private void Update()
  {
  }

  [Token(Token = "0x6000AC4")]
  [Address(RVA = "0xF4C9E0", Offset = "0xF4B7E0", VA = "0x10F4C9E0", Slot = "15")]
  protected override void OnInstanceCreate()
  {
  }

  [Token(Token = "0x6000AC5")]
  [Address(RVA = "0xF4D110", Offset = "0xF4BF10", VA = "0x10F4D110")]
  private void SetSerializeValue()
  {
  }

  [Token(Token = "0x6000AC6")]
  [Address(RVA = "0xF4B350", Offset = "0xF4A150", VA = "0x10F4B350")]
  public FlowNode_GUI()
  {
  }
}
