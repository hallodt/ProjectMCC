var dataSetAnggota = [
    ['1', 'A0001', 'Faris Fadiila', 'Karawang, 1999-08-23', 'Swasta', '2022-12-05'],
    ['2', 'A0002', 'Tamara Gunawan', 'Jakarta, 2001-09-30', 'Swasta', '2022-12-05'],
    ['3', 'A0003', 'Ian Pramana', 'Jakarta, 1998-05-11', 'Swasta', '2022-12-05'],
    ['4', 'A0004', 'Rio Ferrizko', 'Jakarta, 1994-02-4', 'Swasta', '2022-12-05'],
    ['5', 'A0005', 'Lisa Manoban', 'Medan, 1999-09-10', 'Penyanyi', '2022-12-05']
];

$(document).ready(function () {

    $('#TableAnggota').DataTable({
        data: dataSetAnggota,
        columns: [
            { dataSetAnggota: null, },
            { dataSetAnggota: null, },
            { dataSetAnggota: null, },
            { dataSetAnggota: null, },
            { dataSetAnggota: null, },
            { dataSetAnggota: null, },
            {
                dataSetAnggota: null,
                "render": function (data, type, row, meta) {
                    return `
                    <span class='badge badge-success'>Aktif</span>
                    `;
                }
            },
            {
                dataSetAnggota: null,
                "render": function (data, type, row, meta) {
                    return `
                    <div class="btn-group align-items-center" role="group">
					<a href="#editModalAnggota" title="Edit Data" class="btn btn-warning btn-sm" data-toggle="modal" data-target="#editModalAnggota"><i class="fa fa-edit"></i></a>
                    <a title="Keluarkan Anggota" href="#" class="btn btn-primary btn-sm"><i class="fa fa-sign-out-alt"></i></a>	
					<a title="Hapus Data" class="btn btn-danger btn-sm"><i class="fa fa-trash"></i></a>
					</div>
                    `;
                }
            }

        ],
        columnDefs: [
            // Center align the header content of column 1
            { className: "dt-head-center", targets: "_all" },
            // Center align the body content of columns 2, 3, & 4
            { className: "dt-body-center", targets: "_all" }
        ]
    })
});