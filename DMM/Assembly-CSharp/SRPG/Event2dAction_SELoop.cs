// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_SELoop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012A1")]
  [EventActionInfo("New/SE再生(2D)", "SEを再生します", 5592405, 4473992)]
  public class Event2dAction_SELoop : EventAction
  {
    [Token(Token = "0x400453A")]
    [FieldOffset(Offset = "0x0")]
    private static List<Event2dAction_SELoop> instances;
    [Token(Token = "0x400453B")]
    [FieldOffset(Offset = "0x18")]
    public string SE;
    [Token(Token = "0x400453C")]
    [FieldOffset(Offset = "0x1C")]
    public bool Loop;
    [Token(Token = "0x400453D")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public float Interval;
    [Token(Token = "0x400453E")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public int Count;
    [Token(Token = "0x400453F")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public bool async;
    [Token(Token = "0x4004540")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public string SE_ID;
    [Token(Token = "0x4004541")]
    [FieldOffset(Offset = "0x4")]
    private static readonly float MinInterval;
    [Token(Token = "0x4004542")]
    [FieldOffset(Offset = "0x8")]
    private static readonly int MinCount;
    [Token(Token = "0x4004543")]
    [FieldOffset(Offset = "0x30")]
    private float mTimer;
    [Token(Token = "0x4004544")]
    [FieldOffset(Offset = "0x34")]
    private int mCounter;
    [Token(Token = "0x4004545")]
    [FieldOffset(Offset = "0x38")]
    private MySound.CueSheetHandle mHandleSE;
    [Token(Token = "0x4004546")]
    [FieldOffset(Offset = "0xC")]
    private static readonly string SECueSheetName;

    [Token(Token = "0x170008D4")]
    public MySound.CueSheetHandle HandleSE
    {
      [Token(Token = "0x6004EED"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (MySound.CueSheetHandle) null;
      }
    }

    [Token(Token = "0x6004EEE")]
    [Address(RVA = "0x1242570", Offset = "0x1241370", VA = "0x11242570")]
    public static Event2dAction_SELoop Find(string id) => (Event2dAction_SELoop) null;

    [Token(Token = "0x6004EEF")]
    [Address(RVA = "0x12426D0", Offset = "0x12414D0", VA = "0x112426D0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004EF0")]
    [Address(RVA = "0x1242740", Offset = "0x1241540", VA = "0x11242740", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004EF1")]
    [Address(RVA = "0x1242670", Offset = "0x1241470", VA = "0x11242670", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EF2")]
    [Address(RVA = "0x1242800", Offset = "0x1241600", VA = "0x11242800", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004EF3")]
    [Address(RVA = "0x1242960", Offset = "0x1241760", VA = "0x11242960")]
    public Event2dAction_SELoop()
    {
    }

    [Token(Token = "0x6004EF4")]
    [Address(RVA = "0x1242890", Offset = "0x1241690", VA = "0x11242890")]
    static Event2dAction_SELoop()
    {
    }
  }
}
