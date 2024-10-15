// Decompiled with JetBrains decompiler
// Type: SRPG.EventStandChara2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200239F")]
  [AddComponentMenu("UI/EventStandChara2")]
  public class EventStandChara2 : MonoBehaviour
  {
    [Token(Token = "0x400A0A9")]
    [FieldOffset(Offset = "0x0")]
    public static List<EventStandChara2> Instances;
    [Token(Token = "0x400A0AA")]
    [FieldOffset(Offset = "0xC")]
    public string CharaID;
    [Token(Token = "0x400A0AB")]
    [FieldOffset(Offset = "0x10")]
    [HideInInspector]
    public bool mClose;
    [Token(Token = "0x400A0AC")]
    [FieldOffset(Offset = "0x14")]
    public GameObject FaceObject;
    [Token(Token = "0x400A0AD")]
    [FieldOffset(Offset = "0x18")]
    public GameObject BodyObject;
    [Token(Token = "0x400A0AE")]
    [FieldOffset(Offset = "0x1C")]
    private float[] AnchorPostionX;
    [Token(Token = "0x400A0AF")]
    public const float FADEIN_TIME = 0.3f;
    [Token(Token = "0x400A0B0")]
    public const float FADEOUT_TIME = 0.5f;
    [Token(Token = "0x400A0B1")]
    [FieldOffset(Offset = "0x20")]
    private float mFadeTime;
    [Token(Token = "0x400A0B2")]
    [FieldOffset(Offset = "0x24")]
    private bool IsFading;
    [Token(Token = "0x400A0B3")]
    [FieldOffset(Offset = "0x28")]
    private EventStandChara2.StateTypes mState;

    [Token(Token = "0x17001567")]
    public bool IsClose
    {
      [Token(Token = "0x6009A0A"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001568")]
    public bool Fading
    {
      [Token(Token = "0x6009A0B"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001569")]
    public EventStandChara2.StateTypes State
    {
      [Token(Token = "0x6009A0C"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new EventStandChara2.StateTypes();
      }
      [Token(Token = "0x6009A0D"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] set
      {
      }
    }

    [Token(Token = "0x6009A0E")]
    [Address(RVA = "0x5E3B10", Offset = "0x5E2910", VA = "0x105E3B10")]
    public static EventStandChara2 Find(string id) => (EventStandChara2) null;

    [Token(Token = "0x6009A0F")]
    [Address(RVA = "0x5E35C0", Offset = "0x5E23C0", VA = "0x105E35C0")]
    public static void DiscardAll()
    {
    }

    [Token(Token = "0x6009A10")]
    [Address(RVA = "0x5E3C50", Offset = "0x5E2A50", VA = "0x105E3C50")]
    public static string[] GetCharaIDs() => (string[]) null;

    [Token(Token = "0x6009A11")]
    [Address(RVA = "0x5E3510", Offset = "0x5E2310", VA = "0x105E3510")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009A12")]
    [Address(RVA = "0x5E3D70", Offset = "0x5E2B70", VA = "0x105E3D70")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009A13")]
    [Address(RVA = "0x5E3F30", Offset = "0x5E2D30", VA = "0x105E3F30")]
    public void Open()
    {
    }

    [Token(Token = "0x6009A14")]
    [Address(RVA = "0x5E3590", Offset = "0x5E2390", VA = "0x105E3590")]
    public void Close()
    {
    }

    [Token(Token = "0x6009A15")]
    [Address(RVA = "0x5E3F60", Offset = "0x5E2D60", VA = "0x105E3F60")]
    public void StartFadeIn()
    {
    }

    [Token(Token = "0x6009A16")]
    [Address(RVA = "0x5E3F80", Offset = "0x5E2D80", VA = "0x105E3F80")]
    public void StartFadeOut()
    {
    }

    [Token(Token = "0x6009A17")]
    [Address(RVA = "0x5E3FA0", Offset = "0x5E2DA0", VA = "0x105E3FA0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009A18")]
    [Address(RVA = "0x5E3760", Offset = "0x5E2560", VA = "0x105E3760")]
    private void FadeIn(float time)
    {
    }

    [Token(Token = "0x6009A19")]
    [Address(RVA = "0x5E3940", Offset = "0x5E2740", VA = "0x105E3940")]
    private void FadeOut(float time)
    {
    }

    [Token(Token = "0x6009A1A")]
    [Address(RVA = "0x5E3C20", Offset = "0x5E2A20", VA = "0x105E3C20")]
    public float GetAnchorPostionX(int index) => new float();

    [Token(Token = "0x6009A1B")]
    [Address(RVA = "0x5E40A0", Offset = "0x5E2EA0", VA = "0x105E40A0")]
    public EventStandChara2()
    {
    }

    [Token(Token = "0x6009A1C")]
    [Address(RVA = "0x5E4020", Offset = "0x5E2E20", VA = "0x105E4020")]
    static EventStandChara2()
    {
    }

    [Token(Token = "0x20023A0")]
    public enum PositionTypes
    {
      [Token(Token = "0x400A0B5")] OverLeft,
      [Token(Token = "0x400A0B6")] Left,
      [Token(Token = "0x400A0B7")] HLeft,
      [Token(Token = "0x400A0B8")] Center,
      [Token(Token = "0x400A0B9")] HRight,
      [Token(Token = "0x400A0BA")] Right,
      [Token(Token = "0x400A0BB")] OverRight,
      [Token(Token = "0x400A0BC")] None,
    }

    [Token(Token = "0x20023A1")]
    public enum StateTypes
    {
      [Token(Token = "0x400A0BE")] FadeIn,
      [Token(Token = "0x400A0BF")] Active,
      [Token(Token = "0x400A0C0")] FadeOut,
      [Token(Token = "0x400A0C1")] Inactive,
      [Token(Token = "0x400A0C2")] None,
    }
  }
}
