// Decompiled with JetBrains decompiler
// Type: SRPG.UnitAttackRangeWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BB9")]
  [AddComponentMenu("UI/UnitAttackRangeWindow")]
  public class UnitAttackRangeWindow : MonoBehaviour
  {
    [Token(Token = "0x400D6AD")]
    [FieldOffset(Offset = "0xC")]
    public Transform Parent;
    [Token(Token = "0x400D6AE")]
    [FieldOffset(Offset = "0x10")]
    public GameObject RangeTemplate;
    [Token(Token = "0x400D6AF")]
    [FieldOffset(Offset = "0x14")]
    public GameObject SpaceTemplate;
    [Token(Token = "0x400D6B0")]
    [FieldOffset(Offset = "0x18")]
    public Text RangeMinMax;
    [Token(Token = "0x400D6B1")]
    [FieldOffset(Offset = "0x1C")]
    public int BlockSize;
    [Token(Token = "0x400D6B2")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int RANGE_BLOCK_MAX;

    [Token(Token = "0x600C8FD")]
    [Address(RVA = "0x91C270", Offset = "0x91B070", VA = "0x1091C270")]
    private void Start()
    {
    }

    [Token(Token = "0x600C8FE")]
    [Address(RVA = "0x91BBB0", Offset = "0x91A9B0", VA = "0x1091BBB0")]
    private List<string> GetCrossRange(Vector2 target, int min = 0, int max = 0)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x600C8FF")]
    [Address(RVA = "0x91BD20", Offset = "0x91AB20", VA = "0x1091BD20")]
    private List<string> GetDiamondRange(Vector2 target, int min = 0, int max = 0)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x600C900")]
    [Address(RVA = "0x91C110", Offset = "0x91AF10", VA = "0x1091C110")]
    private List<string> GetSquareRange(Vector2 target, int min = 0, int max = 0)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x600C901")]
    [Address(RVA = "0x91C0B0", Offset = "0x91AEB0", VA = "0x1091C0B0")]
    private List<string> GetLaserRange(Vector2 target, int min = 0, int max = 0)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x600C902")]
    [Address(RVA = "0x91B900", Offset = "0x91A700", VA = "0x1091B900")]
    private List<string> GetAllRange(Vector2 target, int min = 0, int max = 0)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x600C903")]
    [Address(RVA = "0x91BA00", Offset = "0x91A800", VA = "0x1091BA00")]
    private List<string> GetBishopRange(Vector2 target, int min = 0, int max = 0)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x600C904")]
    [Address(RVA = "0x91BEC0", Offset = "0x91ACC0", VA = "0x1091BEC0")]
    private List<string> GetHorseRange(Vector2 target, int min = 0, int max = 0)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x600C905")]
    [Address(RVA = "0x91D190", Offset = "0x91BF90", VA = "0x1091D190")]
    public UnitAttackRangeWindow()
    {
    }

    [Token(Token = "0x600C906")]
    [Address(RVA = "0x91D160", Offset = "0x91BF60", VA = "0x1091D160")]
    static UnitAttackRangeWindow()
    {
    }
  }
}
