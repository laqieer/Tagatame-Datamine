// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestPeriodObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200282C")]
  public class PointQuestPeriodObject : MonoBehaviour
  {
    [Token(Token = "0x400BF80")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼処理を行うオブジェクト")]
    private GameObject mObject;
    [Token(Token = "0x400BF81")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [HeaderBar("▼true = 開催中に表示/false = 期間外に表示")]
    private bool isPeriod;
    [Token(Token = "0x400BF82")]
    [FieldOffset(Offset = "0x11")]
    [HeaderBar("▼true = 全期間/false = クエスト挑戦可能期間")]
    [SerializeField]
    private bool isAllTime;

    [Token(Token = "0x600B54F")]
    [Address(RVA = "0x7BBEC0", Offset = "0x7BACC0", VA = "0x107BBEC0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B550")]
    [Address(RVA = "0x7BC130", Offset = "0x7BAF30", VA = "0x107BC130")]
    public PointQuestPeriodObject()
    {
    }
  }
}
