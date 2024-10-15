// Decompiled with JetBrains decompiler
// Type: SRPG.UnitStatusDetailCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C3A")]
  [AddComponentMenu("UI/UnitInventory/UnitStatusDetailCategory")]
  public class UnitStatusDetailCategory : MonoBehaviour
  {
    [Token(Token = "0x400DAFA")]
    private const int UNIT_STATUS_DEFAULT_ASSIST_ESA = 100;
    [Token(Token = "0x400DAFB")]
    private const int UNIT_STATUS_DEFAULT_RESIST_ESA = 100;
    [Token(Token = "0x400DAFC")]
    private const int UNIT_STATUS_DEFAULT_RECOVERY = 100;
    [Token(Token = "0x400DAFD")]
    [FieldOffset(Offset = "0xC")]
    [HideInInspector]
    [SerializeField]
    private UnitStatusDetailCategory.ViewStatusParam m_ViewStatusParam;
    [Token(Token = "0x400DAFE")]
    [FieldOffset(Offset = "0x10")]
    [HideInInspector]
    [SerializeField]
    private bool m_DisableIfListEmpty;
    [Token(Token = "0x400DAFF")]
    [FieldOffset(Offset = "0x14")]
    [HideInInspector]
    [SerializeField]
    private GameObject m_DisableObject;
    [Token(Token = "0x400DB00")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HideInInspector]
    private Transform m_TargetListParent;

    [Token(Token = "0x600CCDD")]
    [Address(RVA = "0x97A490", Offset = "0x979290", VA = "0x1097A490")]
    public void SetValues(BaseStatus status, EElement element)
    {
    }

    [Token(Token = "0x600CCDE")]
    [Address(RVA = "0x979FD0", Offset = "0x978DD0", VA = "0x10979FD0")]
    private void AddTokkouStatusValue(
      ref BaseStatus status,
      ParamTypes paramType,
      EElement element,
      TokkouParam tokkouParam)
    {
    }

    [Token(Token = "0x600CCDF")]
    [Address(RVA = "0x97A060", Offset = "0x978E60", VA = "0x1097A060")]
    private void DisableListChildren()
    {
    }

    [Token(Token = "0x600CCE0")]
    [Address(RVA = "0x97A1B0", Offset = "0x978FB0", VA = "0x1097A1B0")]
    private void DisableObjectWhenListIsEmpty()
    {
    }

    [Token(Token = "0x600CCE1")]
    [Address(RVA = "0x97A3E0", Offset = "0x9791E0", VA = "0x1097A3E0")]
    private static int GetViewOffsetValues(ParamTypes paramType) => new int();

    [Token(Token = "0x600CCE2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitStatusDetailCategory()
    {
    }

    [Token(Token = "0x2002C3B")]
    [Serializable]
    private class ViewStatusParam
    {
      [Token(Token = "0x400DB01")]
      [FieldOffset(Offset = "0x8")]
      public StatusList m_StatusList;
      [Token(Token = "0x400DB02")]
      [FieldOffset(Offset = "0xC")]
      public List<ParamTypes> m_ShowParamType;

      [Token(Token = "0x600CCE3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ViewStatusParam()
      {
      }
    }
  }
}
