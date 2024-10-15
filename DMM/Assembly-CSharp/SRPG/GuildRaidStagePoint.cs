// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidStagePoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002592")]
  [AddComponentMenu("UI/GuildRaid/GuildRaidStagePoint")]
  public class GuildRaidStagePoint : MonoBehaviour
  {
    [Token(Token = "0x400AE4E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private List<Transform> mStageList;
    [Token(Token = "0x400AE4F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GameObject> mStageEffect;

    [Token(Token = "0x17001762")]
    public List<Transform> StageList
    {
      [Token(Token = "0x600A6E4"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<Transform>) null;
      }
    }

    [Token(Token = "0x600A6E5")]
    [Address(RVA = "0x68C660", Offset = "0x68B460", VA = "0x1068C660")]
    public void SetClearEffect(int target)
    {
    }

    [Token(Token = "0x600A6E6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildRaidStagePoint()
    {
    }
  }
}
