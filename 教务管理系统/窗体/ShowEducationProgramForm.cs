﻿using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教务管理系统.DAO;

namespace 教务管理系统.窗体
{
    public partial class ShowEducationProgramForm : Skin_Mac
    {
        public ShowEducationProgramForm()
        {
            InitializeComponent();

            ShowInfo();
        }

        /// <summary>
        /// 展示datagridview
        /// </summary>
        public void ShowInfo()
        {
            string sqlStr = "SELECT [student].scode AS '学号', [student].Name AS '姓名',[student].Gender AS '性别',[class].Name AS '班级名',[major].Name AS '专业',[education_program].Name AS '培养方案', [education_program].Objective AS '培养目标',[education_program].Specification AS '规格要求',[education_program].Duration AS '学制',[education_program].Degree AS '授予学位',[education_program].Min_credit AS '毕业学分要求' ,[education_program].Publish_year AS '制定年份' FROM[student],[class],[major],[education_program] WHERE[student].Class_id=[class].Id AND[class].Major_id=[major].Id AND[education_program].Major_id=[major].Id";
            DataTable dataTable = BaseDao<object>.FindDataTable(sqlStr);
            if (dataTable != null)
            {
                //将数据集合的首张表绑定到dataGridView2的数据源
                this.dataGridView1.DataSource = dataTable;
            }
        }
    }
}
