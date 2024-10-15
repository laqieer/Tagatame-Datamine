// Decompiled with JetBrains decompiler
// Type: DLCDownloadClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000B1")]
public abstract class DLCDownloadClient
{
  [Token(Token = "0x4000358")]
  [FieldOffset(Offset = "0x28")]
  protected long _downloadStart;
  [Token(Token = "0x4000359")]
  [FieldOffset(Offset = "0x30")]
  protected long _downloadEnd;

  [Token(Token = "0x170000AF")]
  public bool IsDone
  {
    [Token(Token = "0x600042F"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000430"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] protected set
    {
    }
  }

  [Token(Token = "0x170000B0")]
  public string HasError
  {
    [Token(Token = "0x6000431"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
    {
      return (string) null;
    }
    [Token(Token = "0x6000432"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] protected set
    {
    }
  }

  [Token(Token = "0x170000B1")]
  public int ContentLength
  {
    [Token(Token = "0x6000433"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
    {
      return new int();
    }
    [Token(Token = "0x6000434"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] protected set
    {
    }
  }

  [Token(Token = "0x170000B2")]
  public bool IsGotRest
  {
    [Token(Token = "0x6000435"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000436"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] protected set
    {
    }
  }

  [Token(Token = "0x170000B3")]
  public bool CanWriteStream
  {
    [Token(Token = "0x6000437"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000438"), Address(RVA = "0x7B1CA0", Offset = "0x7B0AA0", VA = "0x107B1CA0")] set
    {
    }
  }

  [Token(Token = "0x170000B4")]
  public virtual int LoadingSize
  {
    [Token(Token = "0x6000439"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190", Slot = "4")] get
    {
      return new int();
    }
    [Token(Token = "0x600043A"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50", Slot = "5")] protected set
    {
    }
  }

  [Token(Token = "0x170000B5")]
  public virtual byte[] DataBytes
  {
    [Token(Token = "0x600043B"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0", Slot = "6")] get
    {
      return (byte[]) null;
    }
    [Token(Token = "0x600043C"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780", Slot = "7")] protected set
    {
    }
  }

  [Token(Token = "0x170000B6")]
  public virtual int DownloadedSize
  {
    [Token(Token = "0x600043D"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0", Slot = "8")] get
    {
      return new int();
    }
    [Token(Token = "0x600043E"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0", Slot = "9")] protected set
    {
    }
  }

  [Token(Token = "0x170000B7")]
  public double DownloadTime
  {
    [Token(Token = "0x600043F"), Address(RVA = "0xB84570", Offset = "0xB83370", VA = "0x10B84570")] get
    {
      return new double();
    }
  }

  [Token(Token = "0x6000440")]
  public abstract void Download(string url, int size, MonoBehaviour coroutineExecuter = null);

  [Token(Token = "0x6000441")]
  public abstract void Abort();

  [Token(Token = "0x6000442")]
  public abstract void Dispose();

  [Token(Token = "0x6000443")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  protected DLCDownloadClient()
  {
  }
}
