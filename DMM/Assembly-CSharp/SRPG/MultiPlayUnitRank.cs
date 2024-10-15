// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayUnitRank
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002790")]
  [AddComponentMenu("UI/MultiPlayUnitRank")]
  public class MultiPlayUnitRank : MonoBehaviour
  {
    [Token(Token = "0x400BAD8")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400BAD9")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Parent;
    [Token(Token = "0x400BADA")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Root;
    [Token(Token = "0x400BADB")]
    [FieldOffset(Offset = "0x18")]
    public GameObject NotDataObj;
    [Token(Token = "0x400BADC")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject DataObj;

    [Token(Token = "0x600B17F")]
    [Address(RVA = "0x7597D0", Offset = "0x7585D0", VA = "0x107597D0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B180")]
    [Address(RVA = "0x758E40", Offset = "0x757C40", VA = "0x10758E40")]
    private void RefreshData()
    {
    }

    [Token(Token = "0x600B181")]
    [Address(RVA = "0x759480", Offset = "0x758280", VA = "0x10759480")]
    private void SetParam(GameObject item, int rank, MultiRanking param)
    {
    }

    [Token(Token = "0x600B182")]
    [Address(RVA = "0x7592B0", Offset = "0x7580B0", VA = "0x107592B0")]
    public void SetIcon(Transform body, JobParam job)
    {
    }

    [Token(Token = "0x600B183")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MultiPlayUnitRank()
    {
    }
  }
}
