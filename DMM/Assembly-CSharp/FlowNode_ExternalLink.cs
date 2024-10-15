// Decompiled with JetBrains decompiler
// Type: FlowNode_ExternalLink
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001D5")]
[FlowNode.NodeType("ExternalLink", 32741)]
[AddComponentMenu("")]
public class FlowNode_ExternalLink : FlowNode
{
  [Token(Token = "0x400084C")]
  [FieldOffset(Offset = "0x18")]
  public GameObject Target;
  [Token(Token = "0x400084D")]
  [FieldOffset(Offset = "0x1C")]
  protected GameObject mInstance;
  [Token(Token = "0x400084E")]
  [FieldOffset(Offset = "0x20")]
  public string InstanceName;
  [Token(Token = "0x400084F")]
  [FieldOffset(Offset = "0x24")]
  public bool NoAutoDestruct;
  [Token(Token = "0x4000850")]
  [FieldOffset(Offset = "0x25")]
  public bool SetSibling;
  [Token(Token = "0x4000851")]
  [FieldOffset(Offset = "0x28")]
  public Transform Parent;
  [Token(Token = "0x4000852")]
  [FieldOffset(Offset = "0x2C")]
  [HideInInspector]
  [SerializeField]
  private FlowNode_ExternalLink.PinData[] mPins;

  [Token(Token = "0x17000156")]
  public GameObject Instance
  {
    [Token(Token = "0x6000A95"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
    {
      return (GameObject) null;
    }
  }

  [Token(Token = "0x17000157")]
  protected virtual bool ShouldCreateInstanceOnStart
  {
    [Token(Token = "0x6000A96"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "13")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000A97")]
  [Address(RVA = "0xF498E0", Offset = "0xF486E0", VA = "0x10F498E0", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000A98")]
  [Address(RVA = "0xF49C60", Offset = "0xF48A60", VA = "0x10F49C60")]
  protected void CreateInstance()
  {
  }

  [Token(Token = "0x6000A99")]
  [Address(RVA = "0xF49920", Offset = "0xF48720", VA = "0x10F49920")]
  protected void BindPins()
  {
  }

  [Token(Token = "0x6000A9A")]
  [Address(RVA = "0xF4A290", Offset = "0xF49090", VA = "0x10F4A290")]
  protected void DestroyInstance()
  {
  }

  [Token(Token = "0x6000A9B")]
  [Address(RVA = "0xF4A8F0", Offset = "0xF496F0", VA = "0x10F4A8F0", Slot = "8")]
  protected override void OnDestroy()
  {
  }

  [Token(Token = "0x6000A9C")]
  [Address(RVA = "0xF4A5A0", Offset = "0xF493A0", VA = "0x10F4A5A0", Slot = "9")]
  public override FlowNode.Pin[] GetDynamicPins() => (FlowNode.Pin[]) null;

  [Token(Token = "0x6000A9D")]
  [Address(RVA = "0xF4ADA0", Offset = "0xF49BA0", VA = "0x10F4ADA0", Slot = "14")]
  protected virtual void Start()
  {
  }

  [Token(Token = "0x6000A9E")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "15")]
  protected virtual void OnInstanceCreate()
  {
  }

  [Token(Token = "0x6000A9F")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "16")]
  protected virtual void OnInstanceDestroy()
  {
  }

  [Token(Token = "0x6000AA0")]
  [Address(RVA = "0xF4A800", Offset = "0xF49600", VA = "0x10F4A800", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AA1")]
  [Address(RVA = "0xF4A700", Offset = "0xF49500", VA = "0x10F4A700", Slot = "5")]
  public override void OnActivate(int pinID, SerializeValueList _list)
  {
  }

  [Token(Token = "0x6000AA2")]
  [Address(RVA = "0xF4A910", Offset = "0xF49710", VA = "0x10F4A910")]
  public void RefreshPins()
  {
  }

  [Token(Token = "0x6000AA3")]
  [Address(RVA = "0xF4A530", Offset = "0xF49330", VA = "0x10F4A530")]
  private int GenerateUniquePinID() => new int();

  [Token(Token = "0x6000AA4")]
  [Address(RVA = "0xF4A4C0", Offset = "0xF492C0", VA = "0x10F4A4C0")]
  private int FindEmbeddedPin(string pinName) => new int();

  [Token(Token = "0x6000AA5")]
  [Address(RVA = "0xF4ADB0", Offset = "0xF49BB0", VA = "0x10F4ADB0")]
  public FlowNode_ExternalLink()
  {
  }

  [Token(Token = "0x20001D6")]
  [Serializable]
  public struct PinData
  {
    [Token(Token = "0x4000853")]
    [FieldOffset(Offset = "0x0")]
    public int PinID;
    [Token(Token = "0x4000854")]
    [FieldOffset(Offset = "0x4")]
    public string PinName;
    [Token(Token = "0x4000855")]
    [FieldOffset(Offset = "0x8")]
    public FlowNode.PinTypes PinType;
    [Token(Token = "0x4000856")]
    [FieldOffset(Offset = "0xC")]
    [NonSerialized]
    public FlowNode NodeBinding;
  }
}
