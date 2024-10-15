// Decompiled with JetBrains decompiler
// Type: SRPG.AutoEquipArtifacts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002053")]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(101, "初期化完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(111, "詳細表示", FlowNode.PinTypes.Output, 111)]
  [AddComponentMenu("UI/AutoEquipArtifacts")]
  public class AutoEquipArtifacts : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008AFA")]
    private const int PIN_IN_INIT = 0;
    [Token(Token = "0x4008AFB")]
    private const int PIN_IN_SELECT_ITEM = 11;
    [Token(Token = "0x4008AFC")]
    private const int PIN_OUT_INIT = 101;
    [Token(Token = "0x4008AFD")]
    private const int PIN_OUT_SHOW_DETAIL = 111;
    [Token(Token = "0x4008AFE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ArtifactIconTemplate;

    [Token(Token = "0x600864E")]
    [Address(RVA = "0x47B330", Offset = "0x47A130", VA = "0x1047B330")]
    private bool Init() => new bool();

    [Token(Token = "0x600864F")]
    [Address(RVA = "0x47A4C0", Offset = "0x4792C0", VA = "0x1047A4C0", Slot = "4")]
    public void Activated(int PinID)
    {
    }

    [Token(Token = "0x6008650")]
    [Address(RVA = "0x47A620", Offset = "0x479420", VA = "0x1047A620")]
    public static List<ArtifactData> CreateAutoEquipArtifacts(UnitData unit, int job_index)
    {
      return (List<ArtifactData>) null;
    }

    [Token(Token = "0x6008651")]
    [Address(RVA = "0x47B220", Offset = "0x47A020", VA = "0x1047B220")]
    public static List<ArtifactData> CreatePreparedArtifactDatas(
      List<ArtifactData> source,
      int slot_count,
      int slot_max)
    {
      return (List<ArtifactData>) null;
    }

    [Token(Token = "0x6008652")]
    [Address(RVA = "0x47A4F0", Offset = "0x4792F0", VA = "0x1047A4F0")]
    private static int CompareArtifactData(ArtifactData a, ArtifactData b) => new int();

    [Token(Token = "0x6008653")]
    [Address(RVA = "0x47A5C0", Offset = "0x4793C0", VA = "0x1047A5C0")]
    private static int CompareArtifactType(ArtifactData a, ArtifactData b) => new int();

    [Token(Token = "0x6008654")]
    [Address(RVA = "0x47B6C0", Offset = "0x47A4C0", VA = "0x1047B6C0")]
    public void OnClickItem(GameObject item)
    {
    }

    [Token(Token = "0x6008655")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AutoEquipArtifacts()
    {
    }
  }
}
