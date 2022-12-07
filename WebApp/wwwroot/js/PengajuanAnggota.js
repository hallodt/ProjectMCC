$(document).ready(function () {

    $('#TablePengajuanAnggota').DataTable({
        ajax: {
            url: `https://localhost:7189/api/Pengajuan/GetDaftarPengajuan`,
            dataSrc: `data`,
            "headers": {
                'Content-Type': 'application/x-www-form-urlencoded'
            },
            "type": "GET"

        },
        columns: [
            {
                data: null,
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            { data: 'idPengajuan', },
            { data: 'tglPengajuan', },
            { data: 'nama', },
            { data: 'jenisPinjam', },
            { data: 'besarPinjam', },
            {
                data: 'status',
                "render": function (data, type, row, meta) {
                    if (row.status == 'Menunggu') {
                    return `
                    <span class='badge badge-info'>Menunggu</span>
                    `;

                    } else if (row.status == 'Ditolak') {
                    return `
                    <span class='badge badge-Danger'>Ditolak</span>
                    `;

                    } else if (row.status == 'Diterima') {
                    return `
                    <span class='badge badge-success'>Diterima</span>
                    `;
                    }

                }
            },
            {
                data: 'tglAcc',
                "render": function (data, type, row, meta) {
                    if (row.status == 'Menunggu') {
                        return `
                    <span class='badge badge-secondary'>Tidak Ada Data</span>
                    `;
                    } else {
                        data
                    }
                }
            },

        ],
        columnDefs: [
            //{
            //    targets: [5],
            //    render: $.fn.dataTable.render.moment('YYYY-MM-DDTHH:mm:ss.SSS', 'YYYY/MM/DD')
            //},

            {
                targets: [2, 7],
                render: $.fn.dataTable.render.moment('YYYY-MM-DDTHH:mm:ss', 'YYYY/MM/DD')
            },
            // Center align the header content of column 1
            { className: "dt-head-center", targets: "_all" }
            // Center align the body content of columns 2, 3, & 4
        ]
    });
});

function addPengajuanAnggota() {
    let id = 0;
    let tgl_pengajuan = new Date($('#tgl_pengajuan').val()).toISOString();
    let id_user = parseInt($('#id_user').val());
    let id_jenis_pinjaman = parseInt($('#jenis_pinjaman').val());
    let besar_pinjam = parseInt($('#besar_pinjaman').val());
    let besar_angsuran = 0;
    let status = "Status";
    let tgl_acc = new Date($('#tgl_acc').val()).toISOString();

    data = {
        "idPengajuan": id,
        "tglPengajuan": tgl_pengajuan,
        "idUser": id_user,
        "idJenisPinjaman": id_jenis_pinjaman,
        "besarPinjaman": besar_pinjam,
        "besarAngsuran": besar_angsuran,
        "tglAcc": tgl_acc,
        "status": status
    };
    console.log(data);
    $.ajax({
        url: `https://localhost:7189/api/Pengajuan/TambahPengajuan`,
        type: 'POST',
        data: JSON.stringify(data),
        dataType: 'json',
        headers: {
            'Content-Type': 'application/json'
        },
        success: function () {
            Swal.fire({
                icon: 'success',
                title: 'Data Berhasil Ditambahkan',
                text: 'Berhasil menambahkan data pengajuan.',
                showConfirmButton: false,
                timer: 1500
            });
            setTimeout(function () {
                location.reload();
            }, 1500);
        }
    });
}