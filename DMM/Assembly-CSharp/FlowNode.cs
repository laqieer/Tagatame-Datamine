// Decompiled with JetBrains decompiler
// Type: FlowNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Diagnostics;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001B5")]
[AddComponentMenu("")]
public abstract class FlowNode : MonoBehaviour
{
  [Token(Token = "0x40007FF")]
  public const int DefaultNodeColor = 32741;
  [Token(Token = "0x4000800")]
  public const int ListenerNodeColor = 58751;
  [Token(Token = "0x4000801")]
  public const int NativeNodeColor = 16750080;
  [Token(Token = "0x4000802")]
  [FieldOffset(Offset = "0xC")]
  [HideInInspector]
  public Vector2 Position;
  [Token(Token = "0x4000803")]
  [FieldOffset(Offset = "0x14")]
  [HideInInspector]
  public FlowNode.Link[] OutputLinks;

  [Token(Token = "0x6000A3C")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
  public virtual void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A3D")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
  public virtual void OnActivate(int pinID, SerializeValueList valueList)
  {
  }

  [Token(Token = "0x17000155")]
  public FlowNode.Pin[] Pins
  {
    [Token(Token = "0x6000A3E"), Address(RVA = "0xF4FA60", Offset = "0xF4E860", VA = "0x10F4FA60")] get
    {
      return (FlowNode.Pin[]) null;
    }
  }

  [Token(Token = "0x6000A3F")]
  [Address(RVA = "0xF4DC80", Offset = "0xF4CA80", VA = "0x10F4DC80", Slot = "6")]
  public virtual string[] GetInfoLines() => (string[]) null;

  [Token(Token = "0x6000A40")]
  [Address(RVA = "0xE61A80", Offset = "0xE60880", VA = "0x10E61A80", Slot = "7")]
  protected virtual void Awake()
  {
  }

  [Token(Token = "0x6000A41")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
  protected virtual void OnDestroy()
  {
  }

  [Token(Token = "0x6000A42")]
  [Address(RVA = "0xF4DC50", Offset = "0xF4CA50", VA = "0x10F4DC50", Slot = "9")]
  public virtual FlowNode.Pin[] GetDynamicPins() => (FlowNode.Pin[]) null;

  [Token(Token = "0x6000A43")]
  [Address(RVA = "0xF47820", Offset = "0xF46620", VA = "0x10F47820")]
  public void Activate(int pinID)
  {
  }

  [Token(Token = "0x6000A44")]
  [Address(RVA = "0xF47840", Offset = "0xF46640", VA = "0x10F47840")]
  public void Activate(int pinID, SerializeValueList valueList)
  {
  }

  [Token(Token = "0x6000A45")]
  [Address(RVA = "0xF47720", Offset = "0xF46520", VA = "0x10F47720")]
  public int ActivateOutputLinks(int pinID) => new int();

  [Token(Token = "0x6000A46")]
  [Address(RVA = "0xF47620", Offset = "0xF46420", VA = "0x10F47620")]
  public int ActivateOutputLinks(int pinID, SerializeValueList valueList) => new int();

  [Token(Token = "0x6000A47")]
  [Address(RVA = "0xF4EC80", Offset = "0xF4DA80", VA = "0x10F4EC80")]
  protected bool IsParentOf(GameObject go) => new bool();

  [Token(Token = "0x6000A48")]
  [Address(RVA = "0xF4F9C0", Offset = "0xF4E7C0", VA = "0x10F4F9C0")]
  public void RemoveOutputLink(int index)
  {
  }

  [Token(Token = "0x6000A49")]
  [Address(RVA = "0xF4AE40", Offset = "0xF49C40", VA = "0x10F4AE40")]
  public int FindPin(int pinID) => new int();

  [Token(Token = "0x6000A4A")]
  [Address(RVA = "0xF4ED10", Offset = "0xF4DB10", VA = "0x10F4ED10")]
  public void LinkPin(FlowNode.Pin srcPin, FlowNode dest, FlowNode.Pin destPin)
  {
  }

  [Token(Token = "0x6000A4B")]
  [Address(RVA = "0xF4E020", Offset = "0xF4CE20", VA = "0x10F4E020")]
  public Color GetNodeColor() => new Color();

  [Token(Token = "0x6000A4C")]
  [Address(RVA = "0xF4DBC0", Offset = "0xF4C9C0", VA = "0x10F4DBC0", Slot = "10")]
  public virtual string GetCaption() => (string) null;

  [Token(Token = "0x6000A4D")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "11")]
  public virtual bool OnDragUpdate(object[] objectReferences) => new bool();

  [Token(Token = "0x6000A4E")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "12")]
  public virtual bool OnDragPerform(object[] objectReferences) => new bool();

  [Token(Token = "0x6000A4F")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  protected FlowNode()
  {
  }

  [Token(Token = "0x20001B6")]
  public enum PinTypes
  {
    [Token(Token = "0x4000805")] Input,
    [Token(Token = "0x4000806")] Output,
  }

  [Token(Token = "0x20001B7")]
  public class NodeType : Attribute
  {
    [Token(Token = "0x4000807")]
    [FieldOffset(Offset = "0x8")]
    public string Name;
    [Token(Token = "0x4000808")]
    [FieldOffset(Offset = "0xC")]
    public Color Color;

    [Token(Token = "0x6000A50")]
    [Address(RVA = "0xF4FDB0", Offset = "0xF4EBB0", VA = "0x10F4FDB0")]
    public NodeType(string name)
    {
    }

    [Token(Token = "0x6000A51")]
    [Address(RVA = "0xF4FCF0", Offset = "0xF4EAF0", VA = "0x10F4FCF0")]
    public NodeType(string name, int color)
    {
    }
  }

  [Token(Token = "0x20001B8")]
  [Conditional("UNITY_EDITOR")]
  public class NodeUsage : Attribute
  {
    [Token(Token = "0x4000809")]
    [FieldOffset(Offset = "0x8")]
    public string Text;

    [Token(Token = "0x6000A52")]
    [Address(RVA = "0x3010C0", Offset = "0x2FFEC0", VA = "0x103010C0")]
    public NodeUsage(string text)
    {
    }
  }

  [Token(Token = "0x20001B9")]
  public class ShowInInspector : Attribute
  {
    [Token(Token = "0x6000A53")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public ShowInInspector()
    {
    }
  }

  [Token(Token = "0x20001BA")]
  public class ShowInInfo : PropertyAttribute
  {
    [Token(Token = "0x400080A")]
    [FieldOffset(Offset = "0xC")]
    public bool ShowType;

    [Token(Token = "0x6000A54")]
    [Address(RVA = "0xC7EC20", Offset = "0xC7DA20", VA = "0x10C7EC20")]
    public ShowInInfo()
    {
    }

    [Token(Token = "0x6000A55")]
    [Address(RVA = "0xF4FEA0", Offset = "0xF4ECA0", VA = "0x10F4FEA0")]
    public ShowInInfo(bool withType)
    {
    }
  }

  [Token(Token = "0x20001BB")]
  public class FlowDefinitionSearchKeyAttribute : Attribute
  {
    [Token(Token = "0x400080B")]
    [FieldOffset(Offset = "0x8")]
    public System.Type ObjType;

    [Token(Token = "0x6000A56")]
    [Address(RVA = "0x3010C0", Offset = "0x2FFEC0", VA = "0x103010C0")]
    public FlowDefinitionSearchKeyAttribute(System.Type type)
    {
    }
  }

  [Token(Token = "0x20001BC")]
  public class DropTarget : PropertyAttribute
  {
    [Token(Token = "0x400080C")]
    [FieldOffset(Offset = "0xC")]
    public System.Type AcceptType;
    [Token(Token = "0x400080D")]
    [FieldOffset(Offset = "0x10")]
    public bool OnlyChildren;

    [Token(Token = "0x6000A57")]
    [Address(RVA = "0xF46AA0", Offset = "0xF458A0", VA = "0x10F46AA0")]
    public DropTarget(System.Type type, bool onlyChildren)
    {
    }
  }

  [Token(Token = "0x20001BD")]
  [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = true)]
  public class Pin : Attribute
  {
    [Token(Token = "0x400080E")]
    [FieldOffset(Offset = "0x8")]
    public int PinID;
    [Token(Token = "0x400080F")]
    [FieldOffset(Offset = "0xC")]
    public string Name;
    [Token(Token = "0x4000810")]
    [FieldOffset(Offset = "0x10")]
    public Color Color;
    [Token(Token = "0x4000811")]
    [FieldOffset(Offset = "0x20")]
    public FlowNode.PinTypes PinType;
    [Token(Token = "0x4000812")]
    [FieldOffset(Offset = "0x24")]
    public int Priority;

    [Token(Token = "0x6000A58")]
    [Address(RVA = "0xF4FE20", Offset = "0xF4EC20", VA = "0x10F4FE20")]
    public Pin(int id, string name, FlowNode.PinTypes type, int priority = 0)
    {
    }
  }

  [Token(Token = "0x20001BE")]
  [Serializable]
  public struct Link
  {
    [Token(Token = "0x4000813")]
    [FieldOffset(Offset = "0x0")]
    public FlowNode Dest;
    [Token(Token = "0x4000814")]
    [FieldOffset(Offset = "0x4")]
    public int SrcPinID;
    [Token(Token = "0x4000815")]
    [FieldOffset(Offset = "0x8")]
    public int DestPinID;
  }
}
