// Decompiled with JetBrains decompiler
// Type: SRPG.TacticsSceneCameraUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DC1")]
  public static class TacticsSceneCameraUtility
  {
    [Token(Token = "0x6003788")]
    [Address(RVA = "0x10AC920", Offset = "0x10AB720", VA = "0x110AC920")]
    public static void Create(
      this TacticsSceneCamera.AllRangeObj self,
      TacticsSceneCamera.AllRange data)
    {
    }

    [Token(Token = "0x6003789")]
    [Address(RVA = "0x10ACBF0", Offset = "0x10AB9F0", VA = "0x110ACBF0")]
    public static TacticsSceneCamera.AllRange.Group GetGroup(
      this TacticsSceneCamera.AllRange self,
      GameObject value)
    {
      return (TacticsSceneCamera.AllRange.Group) null;
    }

    [Token(Token = "0x600378A")]
    [Address(RVA = "0x10ACD20", Offset = "0x10ABB20", VA = "0x110ACD20")]
    public static bool HasObject(this TacticsSceneCamera.AllRange.Group self, GameObject value)
    {
      return new bool();
    }

    [Token(Token = "0x600378B")]
    [Address(RVA = "0x10ACDC0", Offset = "0x10ABBC0", VA = "0x110ACDC0")]
    public static void Remove(this TacticsSceneCamera.AllRange.Group self, GameObject value)
    {
    }
  }
}
