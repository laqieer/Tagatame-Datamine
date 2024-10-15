// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011E8")]
  [ExecuteInEditMode]
  public abstract class EventAction : ScriptableObject
  {
    [Token(Token = "0x4004128")]
    [FieldOffset(Offset = "0xC")]
    [NonSerialized]
    public EventScript.Sequence Sequence;
    [Token(Token = "0x4004129")]
    [FieldOffset(Offset = "0x10")]
    private bool mEnabled;
    [Token(Token = "0x400412A")]
    [FieldOffset(Offset = "0x11")]
    [HideInInspector]
    public bool Skip;
    [Token(Token = "0x400412B")]
    [FieldOffset(Offset = "0x14")]
    [NonSerialized]
    public EventAction NextAction;
    [Token(Token = "0x400412C")]
    [FieldOffset(Offset = "0x0")]
    public static bool IsPreloading;

    [Token(Token = "0x17000872")]
    public bool enabled
    {
      [Token(Token = "0x6004C1A"), Address(RVA = "0x1220720", Offset = "0x121F520", VA = "0x11220720")] set
      {
      }
      [Token(Token = "0x6004C1B"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004C1C")]
    [Address(RVA = "0x1215590", Offset = "0x1214390", VA = "0x11215590")]
    protected void ActivateNext()
    {
    }

    [Token(Token = "0x6004C1D")]
    [Address(RVA = "0x12154D0", Offset = "0x12142D0", VA = "0x112154D0")]
    protected void ActivateNext(bool keepActive)
    {
    }

    [Token(Token = "0x6004C1E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public virtual void OnActivate()
    {
    }

    [Token(Token = "0x6004C1F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public virtual void OnInactivate()
    {
    }

    [Token(Token = "0x6004C20")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    public virtual void Update()
    {
    }

    [Token(Token = "0x6004C21")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
    protected virtual void OnDestroy()
    {
    }

    [Token(Token = "0x6004C22")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "8")]
    public virtual bool Forward() => new bool();

    [Token(Token = "0x6004C23")]
    [Address(RVA = "0x12201B0", Offset = "0x121EFB0", VA = "0x112201B0", Slot = "9")]
    public virtual bool OnEventSkip() => new bool();

    [Token(Token = "0x6004C24")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "10")]
    public virtual void SkipImmediate()
    {
    }

    [Token(Token = "0x6004C25")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "11")]
    public virtual void GoToEndState()
    {
    }

    [Token(Token = "0x17000873")]
    public virtual bool IsPreloadAssets
    {
      [Token(Token = "0x6004C26"), Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004C27")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "13")]
    public virtual bool ReplaySkipButtonEnable() => new bool();

    [Token(Token = "0x6004C28")]
    [Address(RVA = "0x12205A0", Offset = "0x121F3A0", VA = "0x112205A0", Slot = "14")]
    public virtual IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004C29")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "15")]
    public virtual void PreStart()
    {
    }

    [Token(Token = "0x6004C2A")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "16")]
    public virtual string[] GetStreamingAssets() => (string[]) null;

    [Token(Token = "0x6004C2B")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "17")]
    public virtual string[] GetUnManagedAssetListData() => (string[]) null;

    [Token(Token = "0x6004C2C")]
    [Address(RVA = "0x121A770", Offset = "0x1219570", VA = "0x1121A770")]
    public static string[] GetUnManagedStreamAssets(string[] pair, bool isBGM = false)
    {
      return (string[]) null;
    }

    [Token(Token = "0x17000874")]
    protected Canvas ActiveCanvas
    {
      [Token(Token = "0x6004C2D"), Address(RVA = "0x12205F0", Offset = "0x121F3F0", VA = "0x112205F0")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x17000875")]
    protected RectTransform EventRootTransform
    {
      [Token(Token = "0x6004C2E"), Address(RVA = "0x1220670", Offset = "0x121F470", VA = "0x11220670")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x6004C2F")]
    [Address(RVA = "0x121A4E0", Offset = "0x12192E0", VA = "0x1121A4E0")]
    public static GameObject FindActor(string actorID) => (GameObject) null;

    [Token(Token = "0x6004C30")]
    [Address(RVA = "0x12204F0", Offset = "0x121F2F0", VA = "0x112204F0")]
    protected static Vector3 PointToWorld(IntVector2 pt) => new Vector3();

    [Token(Token = "0x17000876")]
    public static bool IsLoading
    {
      [Token(Token = "0x6004C31"), Address(RVA = "0x12206F0", Offset = "0x121F4F0", VA = "0x112206F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004C32")]
    [Address(RVA = "0x121A600", Offset = "0x1219400", VA = "0x1121A600")]
    public static string[] GetStreamResources(string[] pair) => (string[]) null;

    [Token(Token = "0x6004C33")]
    [Address(RVA = "0x121AAA0", Offset = "0x12198A0", VA = "0x1121AAA0")]
    public static bool IsUnManagedAssets(string name, bool isBGM = false) => new bool();

    [Token(Token = "0x6004C34")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    protected EventAction()
    {
    }
  }
}
