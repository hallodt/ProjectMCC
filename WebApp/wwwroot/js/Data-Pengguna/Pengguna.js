﻿$(document).ready(function () {
    $('#TablePengguna').DataTable({
    ajax: {
        url: 'https://localhost:7189/api/User/GetAdminandPetugas',
        dataSrc: 'data',
        //headers: {
        //    'Authorization': "Bearer " + sessionStorage.getItem("token")
        //},
    },
    columns: [
        {
            data: null,
            render: function (data, type, row, meta) {
                return meta.row + meta.settings._iDisplayStart + 1;
            }
        },
        {
            data: null,
            render: function (data, type, row, meta) {
                return data.nomorAnggota;
            }
        },
        //{
        //    data: null,
        //    render: function (data, type, row, meta) {
        //        return data.idRole;
        //    }
        //},
        {
            data: null,
            render: function (data, type, row, meta) {
                return data.userName;
            }
        },
        //{
        //    data: null,
        //    "render": function (data, type, row, meta) {
        //        if (row.data.nomorAnggota.substr(1) == 'U') {
        //            return `
        //            <span class='badge badge-success'>Admin</span>
        //            `;
        //        } else if (row.data.nomorAnggota.substr(1) == 'P') {
        //            return `
        //            <span class='badge badge-success'>Petugas</span>
        //            `;
        //        }
        //    }
        //},
        {
            data: null,
            render: function (data, type, row, meta) {
                return data.nama;
            }
        },
        {
            data: 'status',
            "render": function (data, type, row, meta) {
                if (row.status == 'Aktif') {
                    return `
                    <span class='badge badge-success'>Aktif</span>
                    `;
                } 
            }
        }

    ],
    columnDefs: [
        // Center align the header content of column 1
        { className: "dt-head-center", targets: "_all" },
        // Center align the body content of columns 2, 3, & 4
        { className: "dt-body-center", targets: "_all" }
    ]
    });
});

function addUser() {
    let url = window.location + '/DataUser'
    let urlParams = new URL(url);
    location.href = urlParams.href;
}