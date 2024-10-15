// Decompiled with JetBrains decompiler
// Type: SRPG.Location
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
  [Token(Token = "0x2000FDD")]
  public class Location
  {
    [Token(Token = "0x4003813")]
    private const float TIMEOUT = 60f;
    [Token(Token = "0x4003814")]
    [FieldOffset(Offset = "0x8")]
    private Location.Result m_Result;
    [Token(Token = "0x4003815")]
    [FieldOffset(Offset = "0xC")]
    private float m_Latitude;
    [Token(Token = "0x4003816")]
    [FieldOffset(Offset = "0x10")]
    private float m_Longitude;
    [Token(Token = "0x4003817")]
    [FieldOffset(Offset = "0x14")]
    private IEnumerator m_Task;
    [Token(Token = "0x4003818")]
    [FieldOffset(Offset = "0x18")]
    private Action<Location> m_Success;
    [Token(Token = "0x4003819")]
    [FieldOffset(Offset = "0x1C")]
    private Action<Location> m_Failed;

    [Token(Token = "0x170005F5")]
    public Vector2 location
    {
      [Token(Token = "0x60041FB"), Address(RVA = "0x1199F90", Offset = "0x1198D90", VA = "0x11199F90")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x170005F6")]
    public float latitude
    {
      [Token(Token = "0x60041FC"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170005F7")]
    public float longitude
    {
      [Token(Token = "0x60041FD"), Address(RVA = "0x2CD710", Offset = "0x2CC510", VA = "0x102CD710")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170005F8")]
    public Location.Result result
    {
      [Token(Token = "0x60041FE"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new Location.Result();
      }
    }

    [Token(Token = "0x170005F9")]
    public static bool isGPSEnable
    {
      [Token(Token = "0x60041FF"), Address(RVA = "0x1199F70", Offset = "0x1198D70", VA = "0x11199F70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004200")]
    [Address(RVA = "0x1199D00", Offset = "0x1198B00", VA = "0x11199D00")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6004201")]
    [Address(RVA = "0x1199D60", Offset = "0x1198B60", VA = "0x11199D60")]
    public void Release()
    {
    }

    [Token(Token = "0x6004202")]
    [Address(RVA = "0x1199ED0", Offset = "0x1198CD0", VA = "0x11199ED0")]
    public void Update()
    {
    }

    [Token(Token = "0x6004203")]
    [Address(RVA = "0x1199BE0", Offset = "0x11989E0", VA = "0x11199BE0")]
    private IEnumerator Coroutine_UpdateLocation() => (IEnumerator) null;

    [Token(Token = "0x6004204")]
    [Address(RVA = "0x1199D70", Offset = "0x1198B70", VA = "0x11199D70")]
    public void Start(Action<Location> success, Action<Location> failed)
    {
    }

    [Token(Token = "0x6004205")]
    [Address(RVA = "0x1199E20", Offset = "0x1198C20", VA = "0x11199E20")]
    public void Start()
    {
    }

    [Token(Token = "0x6004206")]
    [Address(RVA = "0x1199C50", Offset = "0x1198A50", VA = "0x11199C50")]
    public void End()
    {
    }

    [Token(Token = "0x6004207")]
    [Address(RVA = "0x3683C0", Offset = "0x3671C0", VA = "0x103683C0")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x6004208")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnStart()
    {
    }

    [Token(Token = "0x6004209")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnEnd()
    {
    }

    [Token(Token = "0x600420A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Location()
    {
    }

    [Token(Token = "0x2000FDE")]
    public enum Result
    {
      [Token(Token = "0x400381B")] None,
      [Token(Token = "0x400381C")] Working,
      [Token(Token = "0x400381D")] Success,
      [Token(Token = "0x400381E")] Timeout,
      [Token(Token = "0x400381F")] DeviceUnable,
    }
  }
}
