using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	// パターン列挙
	public enum Pattern
	{
		Follow,
		Ignore
	}

	// リストインデックス
	private int m_current_pattern = 0;

	// パターンリスト
	[SerializeField]
	private List<Pattern> m_pattern_list;

	public bool IsFollow()
	{
		// インデックス更新前の番号
		int _current = m_current_pattern;

		// インデックス更新
		m_current_pattern = (m_current_pattern + 1) % m_pattern_list.Count;

		return m_pattern_list[_current] == Pattern.Follow;
	}
}
