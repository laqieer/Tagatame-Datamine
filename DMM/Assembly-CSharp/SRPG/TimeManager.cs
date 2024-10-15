// Decompiled with JetBrains decompiler
// Type: SRPG.TimeManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001939")]
  [AddComponentMenu("Scripts/SRPG/Manager/Time")]
  public class TimeManager : MonoSingleton<TimeManager>
  {
    [Token(Token = "0x4005B2C")]
    [FieldOffset(Offset = "0x0")]
    private static readonly DateTime UNIX_EPOCH;
    [Token(Token = "0x4005B2D")]
    [FieldOffset(Offset = "0x8")]
    public static long UTC2LOCAL;
    [Token(Token = "0x4005B2E")]
    [FieldOffset(Offset = "0x10")]
    public static readonly int DEFAULT_FRAME_RATE;
    [Token(Token = "0x4005B2F")]
    [FieldOffset(Offset = "0x14")]
    private static int mFrameRate;
    [Token(Token = "0x4005B30")]
    [FieldOffset(Offset = "0x18")]
    public static readonly string ISO_8601_FORMAT;
    [Token(Token = "0x4005B31")]
    [FieldOffset(Offset = "0xC")]
    private float mDeltaTime;
    [Token(Token = "0x4005B32")]
    [FieldOffset(Offset = "0x10")]
    private float mFixedDeltaTime;
    [Token(Token = "0x4005B33")]
    [FieldOffset(Offset = "0x14")]
    private float mUnscaledDeltaTime;
    [Token(Token = "0x4005B34")]
    [FieldOffset(Offset = "0x18")]
    private float mUnscaledFixedDeltaTime;
    [Token(Token = "0x4005B35")]
    [FieldOffset(Offset = "0x1C")]
    private float mTimeScale;
    [Token(Token = "0x4005B36")]
    [FieldOffset(Offset = "0x20")]
    private float mReqTimeScale;
    [Token(Token = "0x4005B37")]
    [FieldOffset(Offset = "0x24")]
    private float mHitStop;
    [Token(Token = "0x4005B38")]
    [FieldOffset(Offset = "0x28")]
    private float[] mTimeScales;

    [Token(Token = "0x17000A4C")]
    public static float FPS
    {
      [Token(Token = "0x600667C"), Address(RVA = "0x32DCC0", Offset = "0x32CAC0", VA = "0x1032DCC0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000A4D")]
    public static int FrameRate
    {
      [Token(Token = "0x600667D"), Address(RVA = "0x32DD60", Offset = "0x32CB60", VA = "0x1032DD60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A4E")]
    public static float RealTimeSinceStartup
    {
      [Token(Token = "0x600667E"), Address(RVA = "0x32DD70", Offset = "0x32CB70", VA = "0x1032DD70")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000A4F")]
    public static float DeltaTime
    {
      [Token(Token = "0x600667F"), Address(RVA = "0x32DC80", Offset = "0x32CA80", VA = "0x1032DC80")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000A50")]
    public static float UnscaledDeltaTime
    {
      [Token(Token = "0x6006680"), Address(RVA = "0x32DE30", Offset = "0x32CC30", VA = "0x1032DE30")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000A51")]
    public static float FixedDeltaTime
    {
      [Token(Token = "0x6006681"), Address(RVA = "0x32DD20", Offset = "0x32CB20", VA = "0x1032DD20")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000A52")]
    public static float UnscaledFixedDeltaTime
    {
      [Token(Token = "0x6006682"), Address(RVA = "0x32DE70", Offset = "0x32CC70", VA = "0x1032DE70")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000A53")]
    public static float TimeScale
    {
      [Token(Token = "0x6006683"), Address(RVA = "0x32DDF0", Offset = "0x32CBF0", VA = "0x1032DDF0")] get
      {
        return new float();
      }
      [Token(Token = "0x6006684"), Address(RVA = "0x32DEB0", Offset = "0x32CCB0", VA = "0x1032DEB0")] set
      {
      }
    }

    [Token(Token = "0x6006685")]
    [Address(RVA = "0x32D570", Offset = "0x32C370", VA = "0x1032D570", Slot = "4")]
    protected override void Initialize()
    {
    }

    [Token(Token = "0x6006686")]
    [Address(RVA = "0x32D980", Offset = "0x32C780", VA = "0x1032D980")]
    private void Update()
    {
    }

    [Token(Token = "0x6006687")]
    [Address(RVA = "0x32D800", Offset = "0x32C600", VA = "0x1032D800")]
    public static void StartHitSlow(float rate, float sec)
    {
    }

    [Token(Token = "0x6006688")]
    [Address(RVA = "0x32D7A0", Offset = "0x32C5A0", VA = "0x1032D7A0")]
    public static void SetTimeScale(TimeManager.TimeScaleGroups group, float value)
    {
    }

    [Token(Token = "0x6006689")]
    [Address(RVA = "0x32D610", Offset = "0x32C410", VA = "0x1032D610")]
    public static long Now() => new long();

    [Token(Token = "0x600668A")]
    [Address(RVA = "0x32D3B0", Offset = "0x32C1B0", VA = "0x1032D3B0")]
    public static DateTime FromUnixTime(long unixtime) => new DateTime();

    [Token(Token = "0x600668B")]
    [Address(RVA = "0x32D2E0", Offset = "0x32C0E0", VA = "0x1032D2E0")]
    public static long FromDateTime(DateTime datetime) => new long();

    [Token(Token = "0x600668C")]
    [Address(RVA = "0x32D8B0", Offset = "0x32C6B0", VA = "0x1032D8B0")]
    public static string ToMinSecString(long time) => (string) null;

    [Token(Token = "0x600668D")]
    [Address(RVA = "0x32D520", Offset = "0x32C320", VA = "0x1032D520")]
    public static void HitStop(float sec)
    {
    }

    [Token(Token = "0x17000A54")]
    public static DateTime ServerTime
    {
      [Token(Token = "0x600668E"), Address(RVA = "0x32DD80", Offset = "0x32CB80", VA = "0x1032DD80")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600668F")]
    [Address(RVA = "0x32D450", Offset = "0x32C250", VA = "0x1032D450")]
    public static long GetUnixSec(DateTime targetTime) => new long();

    [Token(Token = "0x6006690")]
    [Address(RVA = "0x32D740", Offset = "0x32C540", VA = "0x1032D740")]
    public static void SetFrameRate(int framerate)
    {
    }

    [Token(Token = "0x6006691")]
    [Address(RVA = "0x32D6E0", Offset = "0x32C4E0", VA = "0x1032D6E0")]
    public static void ResetFrameRate()
    {
    }

    [Token(Token = "0x6006692")]
    [Address(RVA = "0x32DC00", Offset = "0x32CA00", VA = "0x1032DC00")]
    public TimeManager()
    {
    }

    [Token(Token = "0x6006693")]
    [Address(RVA = "0x32DB30", Offset = "0x32C930", VA = "0x1032DB30")]
    static TimeManager()
    {
    }

    [Token(Token = "0x200193A")]
    public enum TimeScaleGroups
    {
      [Token(Token = "0x4005B3A")] Game,
      [Token(Token = "0x4005B3B")] HitStop,
      [Token(Token = "0x4005B3C")] Debug,
      [Token(Token = "0x4005B3D")] BattleSpeed,
      [Token(Token = "0x4005B3E")] BattleDebug,
      [Token(Token = "0x4005B3F")] MAX,
    }
  }
}
