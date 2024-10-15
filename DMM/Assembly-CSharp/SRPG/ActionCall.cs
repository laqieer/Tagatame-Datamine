// Decompiled with JetBrains decompiler
// Type: SRPG.ActionCall
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F3A")]
  [AddComponentMenu("UI/ActionCall")]
  public class ActionCall : MonoBehaviour
  {
    [Token(Token = "0x400835E")]
    [FieldOffset(Offset = "0xC")]
    public string m_EventName;
    [Token(Token = "0x400835F")]
    [FieldOffset(Offset = "0x10")]
    public ActionCall.CustomEvent m_Events;
    [Token(Token = "0x4008360")]
    [FieldOffset(Offset = "0x14")]
    public SerializeValueList m_Value;

    [Token(Token = "0x6007FED")]
    [Address(RVA = "0x406420", Offset = "0x405220", VA = "0x10406420")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007FEE")]
    [Address(RVA = "0x4065D0", Offset = "0x4053D0", VA = "0x104065D0")]
    private void Start()
    {
    }

    [Token(Token = "0x6007FEF")]
    [Address(RVA = "0x406620", Offset = "0x405420", VA = "0x10406620")]
    private void Update()
    {
    }

    [Token(Token = "0x6007FF0")]
    [Address(RVA = "0x406580", Offset = "0x405380", VA = "0x10406580")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6007FF1")]
    [Address(RVA = "0x406530", Offset = "0x405330", VA = "0x10406530")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6007FF2")]
    [Address(RVA = "0x4064A0", Offset = "0x4052A0", VA = "0x104064A0")]
    public void Invoke(ActionCall.EventType eventType, SerializeValueList value)
    {
    }

    [Token(Token = "0x6007FF3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ActionCall()
    {
    }

    [Token(Token = "0x2001F3B")]
    public enum EventType
    {
      [Token(Token = "0x4008362")] AWAKE,
      [Token(Token = "0x4008363")] START,
      [Token(Token = "0x4008364")] UPDATE,
      [Token(Token = "0x4008365")] ONENABLE,
      [Token(Token = "0x4008366")] ONDISABLE,
      [Token(Token = "0x4008367")] OPEN,
      [Token(Token = "0x4008368")] OPENED,
      [Token(Token = "0x4008369")] EVERY,
      [Token(Token = "0x400836A")] CLOSE,
      [Token(Token = "0x400836B")] CLOSED,
      [Token(Token = "0x400836C")] CUSTOM1,
      [Token(Token = "0x400836D")] CUSTOM2,
      [Token(Token = "0x400836E")] CUSTOM3,
      [Token(Token = "0x400836F")] CUSTOM4,
      [Token(Token = "0x4008370")] CUSTOM5,
      [Token(Token = "0x4008371")] CUSTOM6,
      [Token(Token = "0x4008372")] CUSTOM7,
      [Token(Token = "0x4008373")] CUSTOM8,
    }

    [Token(Token = "0x2001F3C")]
    [Serializable]
    public class CustomEvent : UnityEvent<string, ActionCall.EventType, SerializeValueList>
    {
      [Token(Token = "0x6007FF4")]
      [Address(RVA = "0x4112D0", Offset = "0x4100D0", VA = "0x104112D0")]
      public CustomEvent()
      {
      }
    }
  }
}
