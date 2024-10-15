// Decompiled with JetBrains decompiler
// Type: SRPG.FadeController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E30")]
  [AddComponentMenu("")]
  public class FadeController : MonoBehaviour
  {
    [Token(Token = "0x4002B14")]
    private const int FADE_TYPE_MAX = 3;
    [Token(Token = "0x4002B15")]
    [FieldOffset(Offset = "0xC")]
    private Color[] mCurrentColor;
    [Token(Token = "0x4002B16")]
    [FieldOffset(Offset = "0x10")]
    private Color[] mStartColor;
    [Token(Token = "0x4002B17")]
    [FieldOffset(Offset = "0x14")]
    private Color[] mEndColor;
    [Token(Token = "0x4002B18")]
    [FieldOffset(Offset = "0x18")]
    private float[] mCurrentTime;
    [Token(Token = "0x4002B19")]
    [FieldOffset(Offset = "0x1C")]
    private float[] mDuration;
    [Token(Token = "0x4002B1A")]
    [FieldOffset(Offset = "0x20")]
    private Canvas[] mCanvas;
    [Token(Token = "0x4002B1B")]
    [FieldOffset(Offset = "0x24")]
    private RawImage[] mImage;
    [Token(Token = "0x4002B1C")]
    [FieldOffset(Offset = "0x28")]
    private bool[] mInitialized;
    [Token(Token = "0x4002B1D")]
    [FieldOffset(Offset = "0x2C")]
    private Color mSceneFadeStart;
    [Token(Token = "0x4002B1E")]
    [FieldOffset(Offset = "0x3C")]
    private Color mSceneFadeEnd;
    [Token(Token = "0x4002B1F")]
    [FieldOffset(Offset = "0x4C")]
    private float mSceneFadeDuration;
    [Token(Token = "0x4002B20")]
    [FieldOffset(Offset = "0x50")]
    private float mSceneFadeTime;
    [Token(Token = "0x4002B21")]
    [FieldOffset(Offset = "0x54")]
    private TacticsUnitController[] mSceneFadeExcluders;
    [Token(Token = "0x4002B22")]
    [FieldOffset(Offset = "0x58")]
    private TacticsUnitController[] mSceneFadeIncluders;
    [Token(Token = "0x4002B23")]
    [FieldOffset(Offset = "0x0")]
    private static FadeController mInstance;

    [Token(Token = "0x17000437")]
    public static bool InstanceExists
    {
      [Token(Token = "0x6003A7E"), Address(RVA = "0x10DBFD0", Offset = "0x10DADD0", VA = "0x110DBFD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000438")]
    public static FadeController Instance
    {
      [Token(Token = "0x6003A7F"), Address(RVA = "0x10DC030", Offset = "0x10DAE30", VA = "0x110DC030")] get
      {
        return (FadeController) null;
      }
    }

    [Token(Token = "0x6003A80")]
    [Address(RVA = "0x10DAE70", Offset = "0x10D9C70", VA = "0x110DAE70")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003A81")]
    [Address(RVA = "0x10DB8A0", Offset = "0x10DA6A0", VA = "0x110DB8A0")]
    public Color GetCurrentColor(int layer = 0) => new Color();

    [Token(Token = "0x6003A82")]
    [Address(RVA = "0x10DBA60", Offset = "0x10DA860", VA = "0x110DBA60")]
    public void SetCurrentColor(Color color, int layer = 0)
    {
    }

    [Token(Token = "0x6003A83")]
    [Address(RVA = "0x10DB930", Offset = "0x10DA730", VA = "0x110DB930")]
    public bool IsScreenFaded(int layer = 0) => new bool();

    [Token(Token = "0x6003A84")]
    [Address(RVA = "0x10DB8F0", Offset = "0x10DA6F0", VA = "0x110DB8F0")]
    public bool IsFading(int layer = 0) => new bool();

    [Token(Token = "0x6003A85")]
    [Address(RVA = "0x10DB610", Offset = "0x10DA410", VA = "0x110DB610")]
    public void FadeTo(Color dest, float time, int layer = 0)
    {
    }

    [Token(Token = "0x6003A86")]
    [Address(RVA = "0x10DB9D0", Offset = "0x10DA7D0", VA = "0x110DB9D0")]
    public void ResetSceneFade(float time)
    {
    }

    [Token(Token = "0x6003A87")]
    [Address(RVA = "0x10DB560", Offset = "0x10DA360", VA = "0x110DB560")]
    public void BeginSceneFade(
      Color dest,
      float time,
      TacticsUnitController[] excludes,
      TacticsUnitController[] includes)
    {
    }

    [Token(Token = "0x6003A88")]
    [Address(RVA = "0x10DB990", Offset = "0x10DA790", VA = "0x110DB990")]
    public void ReleaseFadeUnits()
    {
    }

    [Token(Token = "0x6003A89")]
    [Address(RVA = "0x10DAB40", Offset = "0x10D9940", VA = "0x110DAB40")]
    private void ApplySceneFade(Color fadeColor)
    {
    }

    [Token(Token = "0x17000439")]
    public bool IsSceneFading
    {
      [Token(Token = "0x6003A8A"), Address(RVA = "0x10DC1B0", Offset = "0x10DAFB0", VA = "0x110DC1B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003A8B")]
    [Address(RVA = "0x10DBAA0", Offset = "0x10DA8A0", VA = "0x110DBAA0")]
    private void UpdateSceneFade()
    {
    }

    [Token(Token = "0x6003A8C")]
    [Address(RVA = "0x10DBBA0", Offset = "0x10DA9A0", VA = "0x110DBBA0")]
    private void Update()
    {
    }

    [Token(Token = "0x6003A8D")]
    [Address(RVA = "0x10DBEA0", Offset = "0x10DACA0", VA = "0x110DBEA0")]
    public FadeController()
    {
    }

    [Token(Token = "0x2000E31")]
    public enum LayerType
    {
      [Token(Token = "0x4002B25")] Normal,
      [Token(Token = "0x4002B26")] Add,
      [Token(Token = "0x4002B27")] AlphaBlend,
    }
  }
}
