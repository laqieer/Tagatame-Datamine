// Decompiled with JetBrains decompiler
// Type: SRPG.ButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002107")]
  public class ButtonEvent : UnityEngine.EventSystems.EventTrigger
  {
    [Token(Token = "0x4008F27")]
    private const float HODL_TIME = 0.5f;
    [Token(Token = "0x4008F28")]
    [FieldOffset(Offset = "0x10")]
    public GameObject syncEvent;
    [Token(Token = "0x4008F29")]
    [FieldOffset(Offset = "0x14")]
    [FormerlySerializedAs("autoLock")]
    public int flag;
    [Token(Token = "0x4008F2A")]
    [FieldOffset(Offset = "0x18")]
    public ButtonEvent.SelectableType selectableType;
    [Token(Token = "0x4008F2B")]
    [FieldOffset(Offset = "0x1C")]
    public List<ButtonEvent.Event> events;
    [Token(Token = "0x4008F2C")]
    [FieldOffset(Offset = "0x20")]
    public bool flickEventEnable;
    [Token(Token = "0x4008F2D")]
    [FieldOffset(Offset = "0x24")]
    public ButtonEvent.Event flickEvent;
    [Token(Token = "0x4008F2E")]
    [FieldOffset(Offset = "0x28")]
    private Selectable m_Selectable;
    [Token(Token = "0x4008F2F")]
    [FieldOffset(Offset = "0x2C")]
    private Vector2 m_Pos;
    [Token(Token = "0x4008F30")]
    [FieldOffset(Offset = "0x34")]
    private bool m_DragMove;
    [Token(Token = "0x4008F31")]
    [FieldOffset(Offset = "0x38")]
    private float m_BeginEnterTime;
    [Token(Token = "0x4008F32")]
    [FieldOffset(Offset = "0x3C")]
    private bool m_Enter;
    [Token(Token = "0x4008F33")]
    [FieldOffset(Offset = "0x3D")]
    private bool m_HoldCheck;
    [Token(Token = "0x4008F34")]
    [FieldOffset(Offset = "0x3E")]
    private bool m_HoldOn;
    [Token(Token = "0x4008F35")]
    public const string SYSTEM_LOCK = "system";
    [Token(Token = "0x4008F36")]
    [FieldOffset(Offset = "0x0")]
    private static Dictionary<string, int> m_Lock;
    [Token(Token = "0x4008F37")]
    [FieldOffset(Offset = "0x4")]
    private static List<ButtonEvent.Listener> m_Listener;

    [Token(Token = "0x170013A2")]
    private bool isInteractable
    {
      [Token(Token = "0x6008A3C"), Address(RVA = "0x4ACDB0", Offset = "0x4ABBB0", VA = "0x104ACDB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008A3D")]
    [Address(RVA = "0x4AA7A0", Offset = "0x4A95A0", VA = "0x104AA7A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008A3E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "38")]
    protected virtual void Start()
    {
    }

    [Token(Token = "0x6008A3F")]
    [Address(RVA = "0x4ACBD0", Offset = "0x4AB9D0", VA = "0x104ACBD0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008A40")]
    [Address(RVA = "0x4AAFE0", Offset = "0x4A9DE0", VA = "0x104AAFE0")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6008A41")]
    [Address(RVA = "0x4AAFE0", Offset = "0x4A9DE0", VA = "0x104AAFE0")]
    private void RefreshButton()
    {
    }

    [Token(Token = "0x6008A42")]
    [Address(RVA = "0x4AC920", Offset = "0x4AB720", VA = "0x104AC920")]
    public void SetFlag(ButtonEvent.Flag value)
    {
    }

    [Token(Token = "0x6008A43")]
    [Address(RVA = "0x4AC000", Offset = "0x4AAE00", VA = "0x104AC000")]
    public void ResetFlag(ButtonEvent.Flag value)
    {
    }

    [Token(Token = "0x6008A44")]
    [Address(RVA = "0x4AAF50", Offset = "0x4A9D50", VA = "0x104AAF50")]
    public bool IsFlag(ButtonEvent.Flag value) => new bool();

    [Token(Token = "0x6008A45")]
    [Address(RVA = "0x4AACD0", Offset = "0x4A9AD0", VA = "0x104AACD0")]
    public bool HasEvent(EventTriggerType trigger) => new bool();

    [Token(Token = "0x6008A46")]
    [Address(RVA = "0x4AAD90", Offset = "0x4A9B90", VA = "0x104AAD90")]
    public bool HasHoldEvent(EventTriggerType trigger) => new bool();

    [Token(Token = "0x6008A47")]
    [Address(RVA = "0x4AAAF0", Offset = "0x4A98F0", VA = "0x104AAAF0")]
    public ButtonEvent.Event[] GetEvents(EventTriggerType trigger) => (ButtonEvent.Event[]) null;

    [Token(Token = "0x6008A48")]
    [Address(RVA = "0x4AABB0", Offset = "0x4A99B0", VA = "0x104AABB0")]
    public ButtonEvent.Event[] GetHoldEvents(EventTriggerType trigger)
    {
      return (ButtonEvent.Event[]) null;
    }

    [Token(Token = "0x6008A49")]
    [Address(RVA = "0x4AA960", Offset = "0x4A9760", VA = "0x104AA960")]
    public ButtonEvent.Event GetEvent(string eventName) => (ButtonEvent.Event) null;

    [Token(Token = "0x6008A4A")]
    [Address(RVA = "0x4AAA20", Offset = "0x4A9820", VA = "0x104AAA20")]
    public ButtonEvent.Event[] GetEvents(string eventName) => (ButtonEvent.Event[]) null;

    [Token(Token = "0x6008A4B")]
    [Address(RVA = "0x4ABF60", Offset = "0x4AAD60", VA = "0x104ABF60")]
    public void PlaySe(ButtonEvent.Event ev)
    {
    }

    [Token(Token = "0x6008A4C")]
    [Address(RVA = "0x4AC5C0", Offset = "0x4AB3C0", VA = "0x104AC5C0")]
    private bool Send(ButtonEvent.Event[] evs, GameObject select) => new bool();

    [Token(Token = "0x6008A4D")]
    [Address(RVA = "0x4AC770", Offset = "0x4AB570", VA = "0x104AC770")]
    private bool Send(ButtonEvent.Event[] evs, Vector2 pos) => new bool();

    [Token(Token = "0x6008A4E")]
    [Address(RVA = "0x4AC410", Offset = "0x4AB210", VA = "0x104AC410")]
    private bool Send(ButtonEvent.Event[] evs, Vector2 pos, Vector2 vct) => new bool();

    [Token(Token = "0x6008A4F")]
    [Address(RVA = "0x4AC3B0", Offset = "0x4AB1B0", VA = "0x104AC3B0")]
    private bool Send(EventTriggerType trigger, GameObject select) => new bool();

    [Token(Token = "0x6008A50")]
    [Address(RVA = "0x4AC3E0", Offset = "0x4AB1E0", VA = "0x104AC3E0")]
    private bool Send(EventTriggerType trigger, Vector2 pos) => new bool();

    [Token(Token = "0x6008A51")]
    [Address(RVA = "0x4AC380", Offset = "0x4AB180", VA = "0x104AC380")]
    private bool Send(EventTriggerType trigger, Vector2 pos, Vector2 vct) => new bool();

    [Token(Token = "0x6008A52")]
    [Address(RVA = "0x4AC130", Offset = "0x4AAF30", VA = "0x104AC130")]
    private bool SendHold(EventTriggerType trigger, Vector2 pos) => new bool();

    [Token(Token = "0x6008A53")]
    [Address(RVA = "0x4AB880", Offset = "0x4AA680", VA = "0x104AB880")]
    private void OnHold(EventTriggerType trigger)
    {
    }

    [Token(Token = "0x6008A54")]
    [Address(RVA = "0x4ABC20", Offset = "0x4AAA20", VA = "0x104ABC20", Slot = "21")]
    public override void OnPointerEnter(PointerEventData data)
    {
    }

    [Token(Token = "0x6008A55")]
    [Address(RVA = "0x4ABCA0", Offset = "0x4AAAA0", VA = "0x104ABCA0", Slot = "22")]
    public override void OnPointerExit(PointerEventData data)
    {
    }

    [Token(Token = "0x6008A56")]
    [Address(RVA = "0x4ABBB0", Offset = "0x4AA9B0", VA = "0x104ABBB0", Slot = "25")]
    public override void OnPointerDown(PointerEventData data)
    {
    }

    [Token(Token = "0x6008A57")]
    [Address(RVA = "0x4ABD10", Offset = "0x4AAB10", VA = "0x104ABD10", Slot = "26")]
    public override void OnPointerUp(PointerEventData data)
    {
    }

    [Token(Token = "0x6008A58")]
    [Address(RVA = "0x4ABB20", Offset = "0x4AA920", VA = "0x104ABB20", Slot = "27")]
    public override void OnPointerClick(PointerEventData data)
    {
    }

    [Token(Token = "0x6008A59")]
    [Address(RVA = "0x4AB3C0", Offset = "0x4AA1C0", VA = "0x104AB3C0", Slot = "34")]
    public override void OnBeginDrag(PointerEventData data)
    {
    }

    [Token(Token = "0x6008A5A")]
    [Address(RVA = "0x4AB570", Offset = "0x4AA370", VA = "0x104AB570", Slot = "23")]
    public override void OnDrag(PointerEventData data)
    {
    }

    [Token(Token = "0x6008A5B")]
    [Address(RVA = "0x4AB780", Offset = "0x4AA580", VA = "0x104AB780", Slot = "35")]
    public override void OnEndDrag(PointerEventData data)
    {
    }

    [Token(Token = "0x6008A5C")]
    [Address(RVA = "0x4ABE70", Offset = "0x4AAC70", VA = "0x104ABE70", Slot = "28")]
    public override void OnSelect(BaseEventData data)
    {
    }

    [Token(Token = "0x6008A5D")]
    [Address(RVA = "0x4ABF10", Offset = "0x4AAD10", VA = "0x104ABF10", Slot = "32")]
    public override void OnUpdateSelected(BaseEventData data)
    {
    }

    [Token(Token = "0x6008A5E")]
    [Address(RVA = "0x4AB4D0", Offset = "0x4AA2D0", VA = "0x104AB4D0", Slot = "37")]
    public override void OnCancel(BaseEventData data)
    {
    }

    [Token(Token = "0x6008A5F")]
    [Address(RVA = "0x4AB520", Offset = "0x4AA320", VA = "0x104AB520", Slot = "29")]
    public override void OnDeselect(BaseEventData data)
    {
    }

    [Token(Token = "0x6008A60")]
    [Address(RVA = "0x4AB710", Offset = "0x4AA510", VA = "0x104AB710", Slot = "24")]
    public override void OnDrop(PointerEventData data)
    {
    }

    [Token(Token = "0x6008A61")]
    [Address(RVA = "0x4AB9D0", Offset = "0x4AA7D0", VA = "0x104AB9D0", Slot = "33")]
    public override void OnInitializePotentialDrag(PointerEventData data)
    {
    }

    [Token(Token = "0x6008A62")]
    [Address(RVA = "0x4ABAC0", Offset = "0x4AA8C0", VA = "0x104ABAC0", Slot = "31")]
    public override void OnMove(AxisEventData data)
    {
    }

    [Token(Token = "0x6008A63")]
    [Address(RVA = "0x4ABD80", Offset = "0x4AAB80", VA = "0x104ABD80", Slot = "30")]
    public override void OnScroll(PointerEventData data)
    {
    }

    [Token(Token = "0x6008A64")]
    [Address(RVA = "0x4ABEC0", Offset = "0x4AACC0", VA = "0x104ABEC0", Slot = "36")]
    public override void OnSubmit(BaseEventData data)
    {
    }

    [Token(Token = "0x6008A65")]
    [Address(RVA = "0x4AC090", Offset = "0x4AAE90", VA = "0x104AC090")]
    public static void Reset()
    {
    }

    [Token(Token = "0x6008A66")]
    [Address(RVA = "0x4AC010", Offset = "0x4AAE10", VA = "0x104AC010")]
    public static void ResetLock(string key)
    {
    }

    [Token(Token = "0x6008A67")]
    [Address(RVA = "0x4AAC70", Offset = "0x4A9A70", VA = "0x104AAC70")]
    public static int GetLockCount() => new int();

    [Token(Token = "0x6008A68")]
    [Address(RVA = "0x4AB290", Offset = "0x4AA090", VA = "0x104AB290")]
    public static void Lock(string key)
    {
    }

    [Token(Token = "0x6008A69")]
    [Address(RVA = "0x4AB130", Offset = "0x4A9F30", VA = "0x104AB130")]
    public static void Lock()
    {
    }

    [Token(Token = "0x6008A6A")]
    [Address(RVA = "0x4AC930", Offset = "0x4AB730", VA = "0x104AC930")]
    public static void UnLock(string key)
    {
    }

    [Token(Token = "0x6008A6B")]
    [Address(RVA = "0x4ACA60", Offset = "0x4AB860", VA = "0x104ACA60")]
    public static void UnLock()
    {
    }

    [Token(Token = "0x6008A6C")]
    [Address(RVA = "0x4AAF70", Offset = "0x4A9D70", VA = "0x104AAF70")]
    public static bool IsLock() => new bool();

    [Token(Token = "0x6008A6D")]
    [Address(RVA = "0x4AA6F0", Offset = "0x4A94F0", VA = "0x104AA6F0")]
    public static ButtonEvent.Listener AddListener(string eventName, Action<bool, object> callback)
    {
      return (ButtonEvent.Listener) null;
    }

    [Token(Token = "0x6008A6E")]
    [Address(RVA = "0x4ABF90", Offset = "0x4AAD90", VA = "0x104ABF90")]
    public static void RemoveListener(ButtonEvent.Listener listener)
    {
    }

    [Token(Token = "0x6008A6F")]
    [Address(RVA = "0x4AAE50", Offset = "0x4A9C50", VA = "0x104AAE50")]
    public static void Invoke(string eventName, object value)
    {
    }

    [Token(Token = "0x6008A70")]
    [Address(RVA = "0x4AA880", Offset = "0x4A9680", VA = "0x104AA880")]
    public static void ForceInvoke(string eventName, object value)
    {
    }

    [Token(Token = "0x6008A71")]
    [Address(RVA = "0x4ACCC0", Offset = "0x4ABAC0", VA = "0x104ACCC0")]
    public ButtonEvent()
    {
    }

    [Token(Token = "0x6008A72")]
    [Address(RVA = "0x4ACBF0", Offset = "0x4AB9F0", VA = "0x104ACBF0")]
    static ButtonEvent()
    {
    }

    [Token(Token = "0x2002108")]
    public enum SelectableType
    {
      [Token(Token = "0x4008F39")] AUTO,
      [Token(Token = "0x4008F3A")] BUTTON,
      [Token(Token = "0x4008F3B")] TOGGLE,
      [Token(Token = "0x4008F3C")] TAB,
    }

    [Token(Token = "0x2002109")]
    public enum Flag
    {
      [Token(Token = "0x4008F3E")] AUTOLOCK = 1,
      [Token(Token = "0x4008F3F")] DRAGMOVELOCK = 2,
    }

    [Token(Token = "0x200210A")]
    [Serializable]
    public class Event
    {
      [Token(Token = "0x4008F40")]
      [FieldOffset(Offset = "0x8")]
      public EventTriggerType trigger;
      [Token(Token = "0x4008F41")]
      [FieldOffset(Offset = "0xC")]
      public string eventName;
      [Token(Token = "0x4008F42")]
      [FieldOffset(Offset = "0x10")]
      public int se;
      [Token(Token = "0x4008F43")]
      [FieldOffset(Offset = "0x14")]
      [FormerlySerializedAs("ignoreLock")]
      public int flag;
      [Token(Token = "0x4008F44")]
      [FieldOffset(Offset = "0x18")]
      public SerializeValueList valueList;

      [Token(Token = "0x170013A3")]
      public bool ignoreLock
      {
        [Token(Token = "0x6008A73"), Address(RVA = "0x4F3E00", Offset = "0x4F2C00", VA = "0x104F3E00")] set
        {
        }
        [Token(Token = "0x6008A74"), Address(RVA = "0x4F3DD0", Offset = "0x4F2BD0", VA = "0x104F3DD0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170013A4")]
      public bool hold
      {
        [Token(Token = "0x6008A75"), Address(RVA = "0x4F3DE0", Offset = "0x4F2BE0", VA = "0x104F3DE0")] set
        {
        }
        [Token(Token = "0x6008A76"), Address(RVA = "0x4F3DC0", Offset = "0x4F2BC0", VA = "0x104F3DC0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6008A77")]
      [Address(RVA = "0x4F3D00", Offset = "0x4F2B00", VA = "0x104F3D00")]
      private void SetFlag(ButtonEvent.Event.Flag value, bool sw)
      {
      }

      [Token(Token = "0x6008A78")]
      [Address(RVA = "0x4AAF50", Offset = "0x4A9D50", VA = "0x104AAF50")]
      private bool IsFlag(ButtonEvent.Event.Flag value) => new bool();

      [Token(Token = "0x6008A79")]
      [Address(RVA = "0x4F3D30", Offset = "0x4F2B30", VA = "0x104F3D30")]
      public Event()
      {
      }

      [Token(Token = "0x200210B")]
      private enum Flag
      {
        [Token(Token = "0x4008F46")] IGNORELOCK = 1,
        [Token(Token = "0x4008F47")] HOLD = 2,
      }
    }

    [Token(Token = "0x200210C")]
    public class Listener
    {
      [Token(Token = "0x4008F48")]
      [FieldOffset(Offset = "0x8")]
      public string eventName;
      [Token(Token = "0x4008F49")]
      [FieldOffset(Offset = "0xC")]
      public Action<bool, object> callback;

      [Token(Token = "0x6008A7A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Listener()
      {
      }
    }
  }
}
