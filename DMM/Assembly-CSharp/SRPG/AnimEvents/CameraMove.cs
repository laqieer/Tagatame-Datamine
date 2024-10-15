// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.CameraMove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032D6")]
  public class CameraMove : AnimEvent
  {
    [Token(Token = "0x400EF6C")]
    [FieldOffset(Offset = "0x18")]
    public CameraMove.eCenterType CenterType;
    [Token(Token = "0x400EF6D")]
    [FieldOffset(Offset = "0x1C")]
    public CameraMove.eDistanceType DistanceType;

    [Token(Token = "0x600DF80")]
    [Address(RVA = "0xA8FE80", Offset = "0xA8EC80", VA = "0x10A8FE80", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DF81")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public CameraMove()
    {
    }

    [Token(Token = "0x20032D7")]
    public enum eCenterType
    {
      [Token(Token = "0x400EF6F")] Self,
      [Token(Token = "0x400EF70")] Targets,
      [Token(Token = "0x400EF71")] All,
    }

    [Token(Token = "0x20032D8")]
    public enum eDistanceType
    {
      [Token(Token = "0x400EF73")] Skill,
      [Token(Token = "0x400EF74")] Far,
      [Token(Token = "0x400EF75")] MoreFar,
      [Token(Token = "0x400EF76")] Auto,
    }
  }
}
