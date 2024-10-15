// Decompiled with JetBrains decompiler
// Type: FlowNode_GUISelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001E0")]
[FlowNode.Pin(1, "Created", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(102, "Preload", FlowNode.PinTypes.Input, 2)]
[FlowNode.Pin(101, "Destroy", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(100, "Create", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("Common/GUISelect", 32741)]
[AddComponentMenu("")]
[FlowNode.Pin(2, "Destroyed", FlowNode.PinTypes.Output, 11)]
public class FlowNode_GUISelect : FlowNode_ExternalLink
{
  [Token(Token = "0x400086B")]
  [FieldOffset(Offset = "0x30")]
  [StringIsResourcePath(typeof (GameObject))]
  public string ResourcePath;
  [Token(Token = "0x400086C")]
  [FieldOffset(Offset = "0x34")]
  public bool Modal;
  [Token(Token = "0x400086D")]
  [FieldOffset(Offset = "0x35")]
  public bool SystemModal;
  [Token(Token = "0x400086E")]
  [FieldOffset(Offset = "0x38")]
  private LoadRequest mResourceRequest;
  [Token(Token = "0x400086F")]
  [FieldOffset(Offset = "0x3C")]
  public bool OverridePriority;
  [Token(Token = "0x4000870")]
  [FieldOffset(Offset = "0x40")]
  public int Priority;
  [Token(Token = "0x4000871")]
  [FieldOffset(Offset = "0x44")]
  public bool LoadImmediately;
  [Token(Token = "0x4000872")]
  [FieldOffset(Offset = "0x48")]
  public GameObject InstanceRef;
  [Token(Token = "0x4000873")]
  [FieldOffset(Offset = "0x4C")]
  protected DestroyEventListener mListener;
  [Token(Token = "0x4000874")]
  private const int STARTADDPIN = 1000;
  [Token(Token = "0x4000875")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private int m_Num;
  [Token(Token = "0x4000876")]
  [FieldOffset(Offset = "0x54")]
  [SerializeField]
  [HideInInspector]
  private FlowNode.Pin[] m_Pins;
  [Token(Token = "0x4000877")]
  [FieldOffset(Offset = "0x58")]
  [StringIsResourcePath(typeof (GameObject))]
  [SerializeField]
  [HideInInspector]
  private string[] AddResourcePath;

  [Token(Token = "0x17000159")]
  protected override bool ShouldCreateInstanceOnStart
  {
    [Token(Token = "0x6000ACE"), Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "13")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000ACF")]
  [Address(RVA = "0xF4B360", Offset = "0xF4A160", VA = "0x10F4B360", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000AD0")]
  [Address(RVA = "0xF4C140", Offset = "0xF4AF40", VA = "0x10F4C140", Slot = "14")]
  protected override void Start()
  {
  }

  [Token(Token = "0x6000AD1")]
  [Address(RVA = "0xF4B3F0", Offset = "0xF4A1F0", VA = "0x10F4B3F0")]
  private void LoadResource()
  {
  }

  [Token(Token = "0x6000AD2")]
  [Address(RVA = "0xF4B710", Offset = "0xF4A510", VA = "0x10F4B710", Slot = "17")]
  protected virtual void OnCreatePinActive()
  {
  }

  [Token(Token = "0x6000AD3")]
  [Address(RVA = "0xF4B4B0", Offset = "0xF4A2B0", VA = "0x10F4B4B0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AD4")]
  [Address(RVA = "0xF4BFC0", Offset = "0xF4ADC0", VA = "0x10F4BFC0")]
  protected void OnInstanceDestroyTrigger(GameObject go)
  {
  }

  [Token(Token = "0x6000AD5")]
  [Address(RVA = "0xF4B8F0", Offset = "0xF4A6F0", VA = "0x10F4B8F0", Slot = "8")]
  protected override void OnDestroy()
  {
  }

  [Token(Token = "0x6000AD6")]
  [Address(RVA = "0xF4C030", Offset = "0xF4AE30", VA = "0x10F4C030", Slot = "16")]
  protected override void OnInstanceDestroy()
  {
  }

  [Token(Token = "0x6000AD7")]
  [Address(RVA = "0xF4B6F0", Offset = "0xF4A4F0", VA = "0x10F4B6F0")]
  private void OnApplicationQuit()
  {
  }

  [Token(Token = "0x6000AD8")]
  [Address(RVA = "0xF4C1B0", Offset = "0xF4AFB0", VA = "0x10F4C1B0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000AD9")]
  [Address(RVA = "0xF4BA20", Offset = "0xF4A820", VA = "0x10F4BA20", Slot = "15")]
  protected override void OnInstanceCreate()
  {
  }

  [Token(Token = "0x6000ADA")]
  [Address(RVA = "0xF4C360", Offset = "0xF4B160", VA = "0x10F4C360")]
  public FlowNode_GUISelect()
  {
  }
}
