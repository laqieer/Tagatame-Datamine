// Decompiled with JetBrains decompiler
// Type: SRPG.EventStandChara
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200239C")]
  [AddComponentMenu("UI/EventStandChara")]
  public class EventStandChara : MonoBehaviour
  {
    [Token(Token = "0x400A095")]
    [FieldOffset(Offset = "0x0")]
    public static List<EventStandChara> Instances;
    [Token(Token = "0x400A096")]
    [FieldOffset(Offset = "0xC")]
    public string CharaID;
    [Token(Token = "0x400A097")]
    [FieldOffset(Offset = "0x10")]
    public bool mClose;
    [Token(Token = "0x400A098")]
    [FieldOffset(Offset = "0x14")]
    private float[] PositionX;
    [Token(Token = "0x400A099")]
    public const float FADEIN_TIME = 0.3f;
    [Token(Token = "0x400A09A")]
    public const float FADEOUT_TIME = 0.5f;
    [Token(Token = "0x400A09B")]
    [FieldOffset(Offset = "0x18")]
    private float FadeTime;
    [Token(Token = "0x400A09C")]
    [FieldOffset(Offset = "0x1C")]
    private bool IsFading;
    [Token(Token = "0x400A09D")]
    [FieldOffset(Offset = "0x20")]
    private EventStandChara.StateTypes mState;

    [Token(Token = "0x17001565")]
    public bool Fading
    {
      [Token(Token = "0x60099F7"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001566")]
    public EventStandChara.StateTypes State
    {
      [Token(Token = "0x60099F8"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new EventStandChara.StateTypes();
      }
      [Token(Token = "0x60099F9"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] set
      {
      }
    }

    [Token(Token = "0x60099FA")]
    [Address(RVA = "0x5E5190", Offset = "0x5E3F90", VA = "0x105E5190")]
    public static EventStandChara Find(string id) => (EventStandChara) null;

    [Token(Token = "0x60099FB")]
    [Address(RVA = "0x5E4DD0", Offset = "0x5E3BD0", VA = "0x105E4DD0")]
    public static void DiscardAll()
    {
    }

    [Token(Token = "0x60099FC")]
    [Address(RVA = "0x5E52A0", Offset = "0x5E40A0", VA = "0x105E52A0")]
    public static string[] GetCharaIDs() => (string[]) null;

    [Token(Token = "0x60099FD")]
    [Address(RVA = "0x5E4C40", Offset = "0x5E3A40", VA = "0x105E4C40")]
    private void Awake()
    {
    }

    [Token(Token = "0x60099FE")]
    [Address(RVA = "0x5E55F0", Offset = "0x5E43F0", VA = "0x105E55F0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60099FF")]
    [Address(RVA = "0x5E56F0", Offset = "0x5E44F0", VA = "0x105E56F0")]
    public void Open(float fade = 0.3f)
    {
    }

    [Token(Token = "0x6009A00")]
    [Address(RVA = "0x5E4CC0", Offset = "0x5E3AC0", VA = "0x105E4CC0")]
    public void Close(float fade = 0.5f)
    {
    }

    [Token(Token = "0x6009A01")]
    [Address(RVA = "0x5E5800", Offset = "0x5E4600", VA = "0x105E5800")]
    public void StartFadeIn(float fade)
    {
    }

    [Token(Token = "0x6009A02")]
    [Address(RVA = "0x5E5910", Offset = "0x5E4710", VA = "0x105E5910")]
    public void StartFadeOut(float fade)
    {
    }

    [Token(Token = "0x6009A03")]
    [Address(RVA = "0x5E5A20", Offset = "0x5E4820", VA = "0x105E5A20")]
    private void Update()
    {
    }

    [Token(Token = "0x6009A04")]
    [Address(RVA = "0x5E4F70", Offset = "0x5E3D70", VA = "0x105E4F70")]
    private void FadeIn(float time)
    {
    }

    [Token(Token = "0x6009A05")]
    [Address(RVA = "0x5E5080", Offset = "0x5E3E80", VA = "0x105E5080")]
    private void FadeOut(float time)
    {
    }

    [Token(Token = "0x6009A06")]
    [Address(RVA = "0x5E53C0", Offset = "0x5E41C0", VA = "0x105E53C0")]
    public void InitPositionX(RectTransform canvasRect)
    {
    }

    [Token(Token = "0x6009A07")]
    [Address(RVA = "0x5E47A0", Offset = "0x5E35A0", VA = "0x105E47A0")]
    public float GetPositionX(int index) => new float();

    [Token(Token = "0x6009A08")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EventStandChara()
    {
    }

    [Token(Token = "0x6009A09")]
    [Address(RVA = "0x5E5CA0", Offset = "0x5E4AA0", VA = "0x105E5CA0")]
    static EventStandChara()
    {
    }

    [Token(Token = "0x200239D")]
    public enum PositionTypes
    {
      [Token(Token = "0x400A09F")] Left,
      [Token(Token = "0x400A0A0")] Center,
      [Token(Token = "0x400A0A1")] Right,
      [Token(Token = "0x400A0A2")] OverLeft,
      [Token(Token = "0x400A0A3")] OverRight,
    }

    [Token(Token = "0x200239E")]
    public enum StateTypes
    {
      [Token(Token = "0x400A0A5")] FadeIn,
      [Token(Token = "0x400A0A6")] Active,
      [Token(Token = "0x400A0A7")] FadeOut,
      [Token(Token = "0x400A0A8")] Inactive,
    }
  }
}
