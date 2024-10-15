// Decompiled with JetBrains decompiler
// Type: SRPG.SceneStartup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001108")]
  [AddComponentMenu("Scripts/SRPG/Scene/Startup")]
  public class SceneStartup : Scene
  {
    [Token(Token = "0x4003D88")]
    [FieldOffset(Offset = "0x0")]
    private static bool mResolutionChanged;
    [Token(Token = "0x4003D89")]
    private const string Key_ClearCache = "CLEARCACHE";
    [Token(Token = "0x4003D8A")]
    [FieldOffset(Offset = "0x10")]
    public bool AutoStart;

    [Token(Token = "0x600483F")]
    [Address(RVA = "0x11F3380", Offset = "0x11F2180", VA = "0x111F3380")]
    private new void Awake()
    {
    }

    [Token(Token = "0x6004840")]
    [Address(RVA = "0x11F3800", Offset = "0x11F2600", VA = "0x111F3800")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x6004841")]
    [Address(RVA = "0x11F35F0", Offset = "0x11F23F0", VA = "0x111F35F0")]
    public static void SetupMessagePackResolvers()
    {
    }

    [Token(Token = "0x6004842")]
    [Address(RVA = "0x11F3870", Offset = "0x11F2670", VA = "0x111F3870")]
    public SceneStartup()
    {
    }
  }
}
