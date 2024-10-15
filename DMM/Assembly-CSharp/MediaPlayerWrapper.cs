// Decompiled with JetBrains decompiler
// Type: MediaPlayerWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using RenderHeads.Media.AVProVideo;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[Token(Token = "0x200000A")]
[AddComponentMenu("AVProVideo/MediaPlayerWrapper")]
public class MediaPlayerWrapper : MonoBehaviour
{
  [Token(Token = "0x400001C")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private MediaPlayer m_MediaPlayer;
  [Token(Token = "0x400001D")]
  [FieldOffset(Offset = "0x10")]
  private bool m_EnableBufferingTimeout;
  [Token(Token = "0x400001E")]
  [FieldOffset(Offset = "0x14")]
  private float m_BufferingGraceTime;
  [Token(Token = "0x400001F")]
  [FieldOffset(Offset = "0x18")]
  private DateTime m_BufferingStartTime;
  [Token(Token = "0x4000020")]
  [FieldOffset(Offset = "0x20")]
  private bool m_IsBuffering;
  [Token(Token = "0x4000021")]
  [FieldOffset(Offset = "0x21")]
  private bool m_IsInitialized;
  [Token(Token = "0x4000022")]
  [FieldOffset(Offset = "0x24")]
  private MediaPlayerWrapper.Event m_CallBack;
  [Token(Token = "0x4000023")]
  [FieldOffset(Offset = "0x28")]
  private Coroutine m_LoadCoroutine;

  [Token(Token = "0x17000003")]
  public MediaPlayerWrapper.Event Events
  {
    [Token(Token = "0x6000034"), Address(RVA = "0x2C72F0", Offset = "0x2C60F0", VA = "0x102C72F0")] get
    {
      return (MediaPlayerWrapper.Event) null;
    }
  }

  [Token(Token = "0x17000004")]
  public bool isAutoPlay
  {
    [Token(Token = "0x6000035"), Address(RVA = "0x2C7380", Offset = "0x2C6180", VA = "0x102C7380")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000036"), Address(RVA = "0x2C73D0", Offset = "0x2C61D0", VA = "0x102C73D0")] set
    {
    }
  }

  [Token(Token = "0x17000005")]
  public bool EnableBufferingTimeout
  {
    [Token(Token = "0x6000037"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000038"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] set
    {
    }
  }

  [Token(Token = "0x17000006")]
  public float BufferingGraceTime
  {
    [Token(Token = "0x6000039"), Address(RVA = "0x2C72E0", Offset = "0x2C60E0", VA = "0x102C72E0")] get
    {
      return new float();
    }
    [Token(Token = "0x600003A"), Address(RVA = "0x2C73A0", Offset = "0x2C61A0", VA = "0x102C73A0")] set
    {
    }
  }

  [Token(Token = "0x600003B")]
  [Address(RVA = "0x2C6ED0", Offset = "0x2C5CD0", VA = "0x102C6ED0")]
  private void Start()
  {
  }

  [Token(Token = "0x600003C")]
  [Address(RVA = "0x2C6820", Offset = "0x2C5620", VA = "0x102C6820")]
  public void LoadFromURL(string url, bool autoPlay)
  {
  }

  [Token(Token = "0x600003D")]
  [Address(RVA = "0x2C68C0", Offset = "0x2C56C0", VA = "0x102C68C0")]
  private IEnumerator LoadInternal(string url, bool autoPlay) => (IEnumerator) null;

  [Token(Token = "0x600003E")]
  [Address(RVA = "0x2C6B60", Offset = "0x2C5960", VA = "0x102C6B60")]
  public void Play()
  {
  }

  [Token(Token = "0x600003F")]
  [Address(RVA = "0x2C6FB0", Offset = "0x2C5DB0", VA = "0x102C6FB0")]
  public void Stop()
  {
  }

  [Token(Token = "0x6000040")]
  [Address(RVA = "0x2C6B00", Offset = "0x2C5900", VA = "0x102C6B00")]
  public void Pause()
  {
  }

  [Token(Token = "0x6000041")]
  [Address(RVA = "0x2C7010", Offset = "0x2C5E10", VA = "0x102C7010")]
  public void Unload()
  {
  }

  [Token(Token = "0x6000042")]
  [Address(RVA = "0x2C6EA0", Offset = "0x2C5CA0", VA = "0x102C6EA0")]
  public void SkipToEnd()
  {
  }

  [Token(Token = "0x6000043")]
  [Address(RVA = "0x2C6720", Offset = "0x2C5520", VA = "0x102C6720")]
  public void BackToStart()
  {
  }

  [Token(Token = "0x6000044")]
  [Address(RVA = "0x2C6BC0", Offset = "0x2C59C0", VA = "0x102C6BC0")]
  public void Reload(bool autoStart = false)
  {
  }

  [Token(Token = "0x6000045")]
  [Address(RVA = "0x2C6D50", Offset = "0x2C5B50", VA = "0x102C6D50")]
  public void Seek01(double value)
  {
  }

  [Token(Token = "0x6000046")]
  [Address(RVA = "0x2C6740", Offset = "0x2C5540", VA = "0x102C6740")]
  public double GetSeek01() => new double();

  [Token(Token = "0x6000047")]
  [Address(RVA = "0x2C6E60", Offset = "0x2C5C60", VA = "0x102C6E60")]
  public void SetVolume(float value)
  {
  }

  [Token(Token = "0x6000048")]
  [Address(RVA = "0x2C67F0", Offset = "0x2C55F0", VA = "0x102C67F0")]
  public float GetVolume() => new float();

  [Token(Token = "0x6000049")]
  [Address(RVA = "0x2C6940", Offset = "0x2C5740", VA = "0x102C6940")]
  private void Notify(MediaPlayerWrapper.Event.Type eventType)
  {
  }

  [Token(Token = "0x600004A")]
  [Address(RVA = "0x2C6A00", Offset = "0x2C5800", VA = "0x102C6A00")]
  private void OnMediaPlayerEvent(
    MediaPlayer mediaPlayer,
    MediaPlayerEvent.EventType eventType,
    ErrorCode errorCode)
  {
  }

  [Token(Token = "0x600004B")]
  [Address(RVA = "0x2C70D0", Offset = "0x2C5ED0", VA = "0x102C70D0")]
  private void Update()
  {
  }

  [Token(Token = "0x600004C")]
  [Address(RVA = "0x2C7070", Offset = "0x2C5E70", VA = "0x102C7070")]
  private void UpdateValues()
  {
  }

  [Token(Token = "0x600004D")]
  [Address(RVA = "0x2C72C0", Offset = "0x2C60C0", VA = "0x102C72C0")]
  public MediaPlayerWrapper()
  {
  }

  [Token(Token = "0x200000B")]
  public class Event : UnityEvent<MediaPlayerWrapper.Event.Type>
  {
    [Token(Token = "0x600004E")]
    [Address(RVA = "0x2C3010", Offset = "0x2C1E10", VA = "0x102C3010")]
    public Event()
    {
    }

    [Token(Token = "0x200000C")]
    public enum Type
    {
      [Token(Token = "0x4000025")] MetaDataReady,
      [Token(Token = "0x4000026")] ReadyToPlay,
      [Token(Token = "0x4000027")] Started,
      [Token(Token = "0x4000028")] FirstFrameReady,
      [Token(Token = "0x4000029")] FinishedPlaying,
      [Token(Token = "0x400002A")] Closing,
      [Token(Token = "0x400002B")] Error,
      [Token(Token = "0x400002C")] SubtitleChange,
      [Token(Token = "0x400002D")] Stalled,
      [Token(Token = "0x400002E")] Unstalled,
      [Token(Token = "0x400002F")] LoadFailed,
      [Token(Token = "0x4000030")] BufferingStart,
      [Token(Token = "0x4000031")] BufferingEnd,
      [Token(Token = "0x4000032")] BufferingTimeout,
    }
  }

  [Token(Token = "0x200000D")]
  public delegate void OnMediaPlayerWrapperEvent(MediaPlayerWrapper.Event.Type eventType);
}
