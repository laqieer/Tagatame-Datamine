// Decompiled with JetBrains decompiler
// Type: SRPG.EventStandCharaController2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023A2")]
  [AddComponentMenu("UI/EventStandCharaController2")]
  public class EventStandCharaController2 : MonoBehaviour
  {
    [Token(Token = "0x400A0C3")]
    [FieldOffset(Offset = "0x0")]
    public static List<EventStandCharaController2> Instances;
    [Token(Token = "0x400A0C4")]
    [FieldOffset(Offset = "0xC")]
    public GameObject[] StandCharaList;
    [Token(Token = "0x400A0C5")]
    [FieldOffset(Offset = "0x10")]
    public string CharaID;
    [Token(Token = "0x400A0C6")]
    [FieldOffset(Offset = "0x14")]
    private float[] AnchorPostionX;
    [Token(Token = "0x400A0C7")]
    [FieldOffset(Offset = "0x18")]
    private int mCurrentIndex;
    [Token(Token = "0x400A0C8")]
    [FieldOffset(Offset = "0x1C")]
    private bool IsFading;
    [Token(Token = "0x400A0C9")]
    private const float FADEIN = 0.5f;
    [Token(Token = "0x400A0CA")]
    private const float FADEOUT = 0.3f;
    [Token(Token = "0x400A0CB")]
    [FieldOffset(Offset = "0x20")]
    private float mFadeTime;
    [Token(Token = "0x400A0CC")]
    [FieldOffset(Offset = "0x24")]
    private string mEmotion;
    [Token(Token = "0x400A0CD")]
    [FieldOffset(Offset = "0x28")]
    private bool mClose;
    [Token(Token = "0x400A0CE")]
    [FieldOffset(Offset = "0x2C")]
    private EventStandCharaController2.StateTypes mState;

    [Token(Token = "0x6009A1D")]
    [Address(RVA = "0x5E4610", Offset = "0x5E3410", VA = "0x105E4610")]
    public static EventStandCharaController2 FindInstances(string id)
    {
      return (EventStandCharaController2) null;
    }

    [Token(Token = "0x6009A1E")]
    [Address(RVA = "0x5E4300", Offset = "0x5E3100", VA = "0x105E4300")]
    public static void DiscardAll()
    {
    }

    [Token(Token = "0x6009A1F")]
    [Address(RVA = "0x5E47A0", Offset = "0x5E35A0", VA = "0x105E47A0")]
    public float GetAnchorPostionX(int index) => new float();

    [Token(Token = "0x6009A20")]
    [Address(RVA = "0x5E4720", Offset = "0x5E3520", VA = "0x105E4720")]
    private GameObject Find(string name) => (GameObject) null;

    [Token(Token = "0x6009A21")]
    [Address(RVA = "0x5E45A0", Offset = "0x5E33A0", VA = "0x105E45A0")]
    private int FindIndex(string name) => new int();

    [Token(Token = "0x1700156A")]
    public bool Fading
    {
      [Token(Token = "0x6009A22"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700156B")]
    public string Emotion
    {
      [Token(Token = "0x6009A23"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A24"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x6009A25")]
    [Address(RVA = "0x5E4110", Offset = "0x5E2F10", VA = "0x105E4110")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009A26")]
    [Address(RVA = "0x5E47D0", Offset = "0x5E35D0", VA = "0x105E47D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009A27")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009A28")]
    [Address(RVA = "0x5E4AD0", Offset = "0x5E38D0", VA = "0x105E4AD0")]
    private void Update()
    {
    }

    [Token(Token = "0x1700156C")]
    public bool IsClose
    {
      [Token(Token = "0x6009A29"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009A2A")]
    [Address(RVA = "0x5E48B0", Offset = "0x5E36B0", VA = "0x105E48B0")]
    public void Open(float fade = 0.5f)
    {
    }

    [Token(Token = "0x6009A2B")]
    [Address(RVA = "0x5E49C0", Offset = "0x5E37C0", VA = "0x105E49C0")]
    public void Open(string name)
    {
    }

    [Token(Token = "0x6009A2C")]
    [Address(RVA = "0x5E4270", Offset = "0x5E3070", VA = "0x105E4270")]
    public void Close(float fade = 0.3f)
    {
    }

    [Token(Token = "0x6009A2D")]
    [Address(RVA = "0x5E49D0", Offset = "0x5E37D0", VA = "0x105E49D0")]
    private void StartFadeIn(float fade)
    {
    }

    [Token(Token = "0x6009A2E")]
    [Address(RVA = "0x5E4A50", Offset = "0x5E3850", VA = "0x105E4A50")]
    private void StartFadeOut(float fade)
    {
    }

    [Token(Token = "0x1700156D")]
    public EventStandCharaController2.StateTypes State
    {
      [Token(Token = "0x6009A2F"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new EventStandCharaController2.StateTypes();
      }
      [Token(Token = "0x6009A30"), Address(RVA = "0x2A09E0", Offset = "0x29F7E0", VA = "0x102A09E0")] set
      {
      }
    }

    [Token(Token = "0x6009A31")]
    [Address(RVA = "0x5E49C0", Offset = "0x5E37C0", VA = "0x105E49C0")]
    public void UpdateEmotion(string name)
    {
    }

    [Token(Token = "0x6009A32")]
    [Address(RVA = "0x5E41F0", Offset = "0x5E2FF0", VA = "0x105E41F0")]
    private void ChangeStandChara(string name)
    {
    }

    [Token(Token = "0x6009A33")]
    [Address(RVA = "0x5E44A0", Offset = "0x5E32A0", VA = "0x105E44A0")]
    private void FadeIn(float time)
    {
    }

    [Token(Token = "0x6009A34")]
    [Address(RVA = "0x5E4520", Offset = "0x5E3320", VA = "0x105E4520")]
    private void FadeOut(float time)
    {
    }

    [Token(Token = "0x6009A35")]
    [Address(RVA = "0x5E4BD0", Offset = "0x5E39D0", VA = "0x105E4BD0")]
    public EventStandCharaController2()
    {
    }

    [Token(Token = "0x6009A36")]
    [Address(RVA = "0x5E4B50", Offset = "0x5E3950", VA = "0x105E4B50")]
    static EventStandCharaController2()
    {
    }

    [Token(Token = "0x20023A3")]
    public enum PositionTypes
    {
      [Token(Token = "0x400A0D0")] OverLeft,
      [Token(Token = "0x400A0D1")] Left,
      [Token(Token = "0x400A0D2")] HLeft,
      [Token(Token = "0x400A0D3")] Center,
      [Token(Token = "0x400A0D4")] HRight,
      [Token(Token = "0x400A0D5")] Right,
      [Token(Token = "0x400A0D6")] OverRight,
      [Token(Token = "0x400A0D7")] None,
    }

    [Token(Token = "0x20023A4")]
    public enum StateTypes
    {
      [Token(Token = "0x400A0D9")] FadeIn,
      [Token(Token = "0x400A0DA")] Active,
      [Token(Token = "0x400A0DB")] FadeOut,
      [Token(Token = "0x400A0DC")] Inactive,
      [Token(Token = "0x400A0DD")] None,
    }
  }
}
